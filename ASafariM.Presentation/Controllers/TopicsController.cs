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
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<TopicsController> _logger;

        public TopicsController(
            ITopicRepository topicRepository,
            IMapper mapper,
            ILogger<TopicsController> logger
        )
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicDto>>> GetTopics()
        {
            var topics = await _topicRepository.GetAllAsync();
            if (topics == null)
                return NotFound();
            _logger.LogInformation("Retrieved {count} topics", topics.Count());
            return Ok(_mapper.Map<IEnumerable<TopicDto>>(topics));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TopicDto>> GetTopic(Guid id)
        {
            var topic = await _topicRepository.GetByIdAsync(id);
            if (topic == null)
                return NotFound();
            _logger.LogInformation("Retrieved topic with id {id}", id);
            return Ok(_mapper.Map<TopicDto>(topic));
        }

        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<TopicDto>> GetTopicBySlug(string slug)
        {
            var topic = await _topicRepository.GetBySlugAsync(slug);
            if (topic == null)
                return NotFound();
            _logger.LogInformation("Retrieved topic with slug {slug}", slug);
            return Ok(_mapper.Map<TopicDto>(topic));
        }

        [HttpGet("{id}/children")]
        public async Task<ActionResult<IEnumerable<TopicDto>>> GetChildTopics(Guid id)
        {
            var topics = await _topicRepository.GetChildTopicsAsync(id);
            if (topics == null)
                return NotFound();
            _logger.LogInformation("Retrieved child topics for topic with id {id}", id);
            return Ok(_mapper.Map<IEnumerable<TopicDto>>(topics));
        }

        [HttpPost]
        public async Task<ActionResult<TopicDto>> CreateTopic(CreateTopicCommand command)
        {
            if (await _topicRepository.SlugExistsAsync(command.Slug))
                return BadRequest("Slug already exists");

            var topic = _mapper.Map<Topic>(command);
            topic.Slug = command.Slug.ToLower();
            await _topicRepository.AddAsync(topic);
            await _topicRepository.SaveChangesAsync();
            _logger.LogInformation("Created topic with id {id}", topic.Id);
            _logger.LogInformation("Created topic with slug {slug}", topic.Slug);
            _logger.LogInformation("Created topic with name {name}", topic.Name);
            _logger.LogInformation(
                "Created topic with description {description}",
                topic.Description
            );
            _logger.LogInformation(
                "Created topic with parent topic id {parentTopicId}",
                topic.ParentTopicId
            );
            return CreatedAtAction(
                nameof(GetTopic),
                new { id = topic.Id },
                _mapper.Map<TopicDto>(topic)
            );
        }

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
            await _topicRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
