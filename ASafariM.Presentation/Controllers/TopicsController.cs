using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IMapper _mapper;

        public TopicsController(ITopicRepository topicRepository, IMapper mapper)
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicDto>>> GetTopics()
        {
            var topics = await _topicRepository.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<TopicDto>>(topics));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TopicDto>> GetTopic(Guid id)
        {
            var topic = await _topicRepository.GetByIdAsync(id);
            if (topic == null)
                return NotFound();

            return Ok(_mapper.Map<TopicDto>(topic));
        }

        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<TopicDto>> GetTopicBySlug(string slug)
        {
            var topic = await _topicRepository.GetBySlugAsync(slug);
            if (topic == null)
                return NotFound();

            return Ok(_mapper.Map<TopicDto>(topic));
        }

        [HttpGet("{id}/children")]
        public async Task<ActionResult<IEnumerable<TopicDto>>> GetChildTopics(Guid id)
        {
            var topics = await _topicRepository.GetChildTopicsAsync(id);
            return Ok(_mapper.Map<IEnumerable<TopicDto>>(topics));
        }

        [Authorize(Roles = "Admin,Editor")]
        [HttpPost]
        public async Task<ActionResult<TopicDto>> CreateTopic(CreateTopicCommand command)
        {
            if (await _topicRepository.SlugExistsAsync(command.Slug))
                return BadRequest("Slug already exists");

            var topic = _mapper.Map<Topic>(command);
            topic.CreatedBy = !string.IsNullOrEmpty(User.Identity?.Name)
                ? Guid.Parse(User.Identity.Name)
                : null;
            topic.CreatedAt = DateTime.UtcNow;
            topic.UpdatedAt = DateTime.UtcNow;
            topic.IsDeleted = false;
            topic.DeletedAt = null;
            await _topicRepository.AddAsync(topic);
            return CreatedAtAction(
                nameof(GetTopic),
                new { id = topic.Id },
                _mapper.Map<TopicDto>(topic)
            );
        }

        [Authorize(Roles = "Admin,Editor")]
        [HttpPut("{id}")]
        public async Task<ActionResult<TopicDto>> UpdateTopic(Guid id, UpdateTopicCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            var existingTopic = await _topicRepository.GetByIdAsync(id);
            if (existingTopic == null)
                return NotFound();

            if (
                command.Slug != existingTopic.Slug
                && await _topicRepository.SlugExistsAsync(command.Slug)
            )
                return BadRequest("Slug already exists");

            _mapper.Map(command, existingTopic);
            existingTopic.UpdatedBy = !string.IsNullOrEmpty(User.Identity?.Name)
                ? Guid.Parse(User.Identity.Name)
                : null;
            existingTopic.UpdatedAt = DateTime.UtcNow;

            await _topicRepository.UpdateAsync(existingTopic);
            return Ok(_mapper.Map<TopicDto>(existingTopic));
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTopic(Guid id)
        {
            var topic = await _topicRepository.GetByIdAsync(id);
            if (topic == null)
                return NotFound();

            topic.DeletedBy = !string.IsNullOrEmpty(User.Identity?.Name)
                ? Guid.Parse(User.Identity.Name)
                : null;
            await _topicRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
