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
    public class TagsController : ControllerBase
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public TagsController(ITagRepository tagRepository, IMapper mapper)
        {
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TagDto>>> GetTags()
        {
            var tags = await _tagRepository.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<TagDto>>(tags));
        }

        // Create a new tag
        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            var tag = new Tag
            {
                Name = command.Name,
                Description = command.Description + " (Created by " + User?.Identity?.Name + ")",
                Slug = command.Slug,
                CreatedBy = User?.Identity?.Name ?? "System",
                UpdatedBy = User?.Identity?.Name ?? "System",
                IsActive = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            await _tagRepository.AddAsync(tag);
            return Ok(tag);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TagDto>> GetTag(Guid id)
        {
            var tag = await _tagRepository.GetByIdAsync(id);
            if (tag == null)
                return NotFound();

            return Ok(_mapper.Map<TagDto>(tag));
        }

        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<TagDto>> GetTagBySlug(string slug)
        {
            var tag = await _tagRepository.GetBySlugAsync(slug);
            if (tag == null)
                return NotFound();

            return Ok(_mapper.Map<TagDto>(tag));
        }

        [HttpGet("post/{postId}")]
        public async Task<ActionResult<IEnumerable<TagDto>>> GetTagsByPost(Guid postId)
        {
            var tags = await _tagRepository.GetTagsByPostIdAsync(postId);
            return Ok(_mapper.Map<IEnumerable<TagDto>>(tags));
        }

        [Authorize(Roles = "Admin,Editor")]
        [HttpPut("{id}")]
        public async Task<ActionResult<TagDto>> UpdateTag(Guid id, UpdateTagCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            var existingTag = await _tagRepository.GetByIdAsync(id);
            if (existingTag == null)
                return NotFound();

            if (
                command.Slug != existingTag.Slug
                && await _tagRepository.SlugExistsAsync(command.Slug)
            )
                return BadRequest("Slug already exists");

            _mapper.Map(command, existingTag);
            existingTag.UpdatedBy = User.Identity.Name;
            existingTag.UpdatedAt = DateTime.UtcNow;

            await _tagRepository.UpdateAsync(existingTag);
            return Ok(_mapper.Map<TagDto>(existingTag));
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTag(Guid id)
        {
            var tag = await _tagRepository.GetByIdAsync(id);
            if (tag == null)
                return NotFound();

            tag.DeletedBy = User.Identity.Name;
            await _tagRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
