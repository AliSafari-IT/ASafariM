using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;

        public PostsController(
            IPostRepository postRepository,
            ITagRepository tagRepository,
            IMapper mapper
        )
        {
            _postRepository = postRepository;
            _tagRepository = tagRepository;
            _mapper = mapper;
        }

        private bool IsAdmin =>
            User.IsInRole(RoleEnum.Admin.ToString())
            || User.IsInRole(RoleEnum.SuperAdmin.ToString());
        private bool IsModerator => User.IsInRole(RoleEnum.Moderator.ToString());
        private bool IsEditor => User.IsInRole(RoleEnum.Editor.ToString());
        private string CurrentUserId => User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        private async Task<bool> CanModifyPost(Post post)
        {
            if (IsAdmin)
                return true;
            if (post.CreatedBy == CurrentUserId)
                return true;
            if (IsModerator)
            {
                // Moderators can modify posts from editors but not from admins
                var creatorIsAdmin =
                    await IsUserInRole(post.CreatedBy, RoleEnum.Admin.ToString())
                    || await IsUserInRole(post.CreatedBy, RoleEnum.SuperAdmin.ToString());
                return !creatorIsAdmin;
            }
            return false;
        }

        private async Task<bool> CanDeletePost(Post post)
        {
            if (IsAdmin)
                return true;
            if (post.CreatedBy == CurrentUserId)
                return true;
            // Moderators cannot delete any posts
            return false;
        }

        private async Task<bool> IsUserInRole(string userId, string role)
        {
            // This should be implemented to check user roles from your user service
            // For now, returning false as a placeholder
            return false;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPosts()
        {
            var posts = await _postRepository.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
        }

        [HttpGet("published")]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPublishedPosts()
        {
            var posts = await _postRepository.GetPublishedAsync();
            return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostDto>> GetPost(Guid id)
        {
            var post = await _postRepository.GetByIdAsync(id);
            if (post == null)
                return NotFound();

            // If post is not published, check permissions
            if (!post.IsPublished)
            {
                if (!(await CanModifyPost(post)))
                    return Forbid();
            }

            return Ok(_mapper.Map<PostDto>(post));
        }

        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<PostDto>> GetPostBySlug(string slug)
        {
            var post = await _postRepository.GetBySlugAsync(slug);
            if (post == null)
                return NotFound();

            // If post is not published, check permissions
            if (!post.IsPublished)
            {
                if (!(await CanModifyPost(post)))
                    return Forbid();
            }

            return Ok(_mapper.Map<PostDto>(post));
        }

        [HttpGet("topic/{topicId}")]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPostsByTopic(Guid topicId)
        {
            var posts = await _postRepository.GetByTopicIdAsync(topicId);
            return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
        }

        [HttpGet("tag/{tagId}")]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPostsByTag(Guid tagId)
        {
            var posts = await _postRepository.GetByTagIdAsync(tagId);
            return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
        }

        [HttpPost("{id}/view")]
        public async Task<ActionResult<int>> IncrementViewCount(Guid id)
        {
            var viewCount = await _postRepository.IncrementViewCountAsync(id);
            if (viewCount == 0)
                return NotFound();

            return Ok(viewCount);
        }

        [Authorize(Roles = "Admin,SuperAdmin,Editor,Moderator")]
        [HttpPost]
        public async Task<ActionResult<PostDto>> CreatePost(CreatePostCommand command)
        {
            if (await _postRepository.SlugExistsAsync(command.Slug))
                return BadRequest("Slug already exists");

            var post = _mapper.Map<Post>(command);
            post.CreatedBy = CurrentUserId;
            post.UpdatedBy = CurrentUserId;
            post.CreatedAt = DateTime.UtcNow;
            post.UpdatedAt = DateTime.UtcNow;
            post.LastUpdated = DateTime.UtcNow;
            post.IsActive = true;

            if (command.IsPublished)
            {
                post.PublishedDate = DateTime.UtcNow;
                post.Author = CurrentUserId;
            }

            // Add tags
            if (command.TagIds != null)
            {
                post.PostTags = new List<PostTag>();
                foreach (var tagId in command.TagIds)
                {
                    if (await _tagRepository.ExistsAsync(tagId))
                    {
                        post.PostTags.Add(
                            new PostTag
                            {
                                TagId = tagId,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = CurrentUserId,
                            }
                        );
                    }
                }
            }

            await _postRepository.AddAsync(post);
            return CreatedAtAction(
                nameof(GetPost),
                new { id = post.Id },
                _mapper.Map<PostDto>(post)
            );
        }

        [Authorize(Roles = "Admin,SuperAdmin,Editor,Moderator")]
        [HttpPut("{id}")]
        public async Task<ActionResult<PostDto>> UpdatePost(Guid id, UpdatePostCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            var existingPost = await _postRepository.GetByIdAsync(id);
            if (existingPost == null)
                return NotFound();

            if (!(await CanModifyPost(existingPost)))
                return Forbid();

            if (
                command.Slug != existingPost.Slug
                && await _postRepository.SlugExistsAsync(command.Slug)
            )
                return BadRequest("Slug already exists");

            // Update basic properties
            _mapper.Map(command, existingPost);
            existingPost.UpdatedBy = CurrentUserId;
            existingPost.UpdatedAt = DateTime.UtcNow;
            existingPost.LastUpdated = DateTime.UtcNow;

            // Handle publication status changes
            if (command.IsPublished && !existingPost.IsPublished)
            {
                existingPost.PublishedDate = DateTime.UtcNow;
                existingPost.Author = CurrentUserId;
            }

            // Update tags
            if (command.TagIds != null)
            {
                existingPost.PostTags.Clear();
                foreach (var tagId in command.TagIds)
                {
                    if (await _tagRepository.ExistsAsync(tagId))
                    {
                        existingPost.PostTags.Add(
                            new PostTag
                            {
                                TagId = tagId,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = CurrentUserId,
                            }
                        );
                    }
                }
            }

            await _postRepository.UpdateAsync(existingPost);
            return Ok(_mapper.Map<PostDto>(existingPost));
        }

        [Authorize(Roles = "Admin,SuperAdmin,Editor,Moderator")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePost(Guid id)
        {
            var post = await _postRepository.GetByIdAsync(id);
            if (post == null)
                return NotFound();

            if (!(await CanDeletePost(post)))
                return Forbid();

            post.DeletedBy = CurrentUserId;
            await _postRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
