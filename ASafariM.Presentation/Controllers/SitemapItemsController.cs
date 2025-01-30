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
    public class SitemapItemsController : ControllerBase
    {
        private readonly ISitemapItemRepository _sitemapItemRepository;
        private readonly IMapper _mapper;

        public SitemapItemsController(ISitemapItemRepository sitemapItemRepository, IMapper mapper)
        {
            _sitemapItemRepository = sitemapItemRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SitemapItemDto>>> GetSitemapItems()
        {
            var items = await _sitemapItemRepository.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<SitemapItemDto>>(items));
        }

        [HttpGet("root")]
        public async Task<ActionResult<IEnumerable<SitemapItemDto>>> GetRootItems()
        {
            var items = await _sitemapItemRepository.GetRootItemsAsync();
            return Ok(_mapper.Map<IEnumerable<SitemapItemDto>>(items));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SitemapItemDto>> GetSitemapItem(Guid id)
        {
            var item = await _sitemapItemRepository.GetByIdAsync(id);
            if (item == null)
                return NotFound();

            return Ok(_mapper.Map<SitemapItemDto>(item));
        }

        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<SitemapItemDto>> GetSitemapItemBySlug(string slug)
        {
            var item = await _sitemapItemRepository.GetBySlugAsync(slug);
            if (item == null)
                return NotFound();

            return Ok(_mapper.Map<SitemapItemDto>(item));
        }

        [HttpGet("{id}/children")]
        public async Task<ActionResult<IEnumerable<SitemapItemDto>>> GetChildItems(Guid id)
        {
            var items = await _sitemapItemRepository.GetChildrenAsync(id);
            return Ok(_mapper.Map<IEnumerable<SitemapItemDto>>(items));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<SitemapItemDto>> CreateSitemapItem(
            CreateSitemapItemCommand command
        )
        {
            if (await _sitemapItemRepository.SlugExistsAsync(command.Slug))
                return BadRequest("Slug already exists");

            var item = _mapper.Map<SitemapItem>(command);
            item.CreatedBy = User.Identity.Name;
            item.UpdatedBy = User.Identity.Name;
            item.CreatedAt = DateTime.UtcNow;
            item.UpdatedAt = DateTime.UtcNow;
            item.IsActive = true;

            if (command.IsPublished)
            {
                item.PublishedDate = DateTime.UtcNow;
                item.PublishedBy = User.Identity.Name;
            }

            await _sitemapItemRepository.AddAsync(item);
            return CreatedAtAction(
                nameof(GetSitemapItem),
                new { id = item.Id },
                _mapper.Map<SitemapItemDto>(item)
            );
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<ActionResult<SitemapItemDto>> UpdateSitemapItem(
            Guid id,
            UpdateSitemapItemCommand command
        )
        {
            if (id != command.Id)
                return BadRequest();

            var existingItem = await _sitemapItemRepository.GetByIdAsync(id);
            if (existingItem == null)
                return NotFound();

            if (
                command.Slug != existingItem.Slug
                && await _sitemapItemRepository.SlugExistsAsync(command.Slug)
            )
                return BadRequest("Slug already exists");

            _mapper.Map(command, existingItem);
            existingItem.UpdatedBy = User.Identity.Name;
            existingItem.UpdatedAt = DateTime.UtcNow;

            if (command.IsPublished && !existingItem.IsPublished)
            {
                existingItem.PublishedDate = DateTime.UtcNow;
                existingItem.PublishedBy = User.Identity.Name;
            }

            await _sitemapItemRepository.UpdateAsync(existingItem);
            return Ok(_mapper.Map<SitemapItemDto>(existingItem));
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSitemapItem(Guid id)
        {
            var item = await _sitemapItemRepository.GetByIdAsync(id);
            if (item == null)
                return NotFound();

            item.DeletedBy = User.Identity.Name;
            await _sitemapItemRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
