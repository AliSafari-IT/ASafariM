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
            if (string.IsNullOrEmpty(command.Name))
                return BadRequest("Name is required");

            var tag = new Tag()
            {
                Name = command.Name,
                Description = command.Description + " (Created by " + User?.Identity?.Name + ")",
                Slug = command.Slug + "-" + Guid.NewGuid().ToString().Substring(0, 8),
            };

            await _tagRepository.AddAsync(tag);
            await _tagRepository.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTag), new { id = tag.Id }, tag);
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

        [HttpPut("{id}")]
        public async Task<ActionResult<TagDto>> UpdateTag(Guid id, UpdateTagCommand command)
        {
            try
            {
                var existingTag = await _tagRepository.GetByIdAsync(id);
                if (existingTag == null)
                    return NotFound($"Tag with ID {id} not found");

                // Check if the slug is being changed and if it already exists
                if (
                    command.Slug != existingTag.Slug
                    && await _tagRepository.SlugExistsAsync(command.Slug)
                )
                    return BadRequest("Slug already exists");

                // Update the tag properties
                existingTag.Name = command.Name;
                existingTag.Description =
                    command.Description + " (Updated by " + User?.Identity?.Name + ")";
                existingTag.Slug = command.Slug;

                // Save the changes
                await _tagRepository.UpdateAsync(existingTag);
                await _tagRepository.SaveChangesAsync();

                return Ok(existingTag);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTag(Guid id)
        {
            var tag = await _tagRepository.GetByIdAsync(id);
            if (tag == null)
                return NotFound();
            await _tagRepository.DeleteAsync(id);
            await _tagRepository.SaveChangesAsync();
            return NoContent();
        }
    }
}
