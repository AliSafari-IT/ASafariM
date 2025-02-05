using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Services;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IUserService _userService;
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
            try
            {
                Log.Information("Checking if user {UserId} is in role: {Role}", userId, role);
                var guidId = Guid.Parse(userId);
                var user = await _userService.GetUserByIdAsync(guidId);
                if (user == null)
                {
                    Log.Warning("User not found with ID: {UserId}", userId);
                    return false;
                }

                // Check if user is admin when checking for admin roles
                if ((role == RoleEnum.Admin.ToString() || role == RoleEnum.SuperAdmin.ToString()) && user.IsAdmin)
                {
                    return true;
                }

                // For now, return false for other roles since we don't have direct role access
                // TODO: Implement proper role checking when role management is added
                Log.Warning("Role check not fully implemented for role: {Role}", role);
                return false;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error checking role for user {UserId}", userId);
                return false;
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPosts()
        {
            try
            {
                Log.Information("Fetching all posts");
                var posts = await _postRepository.GetAllAsync();
                Log.Information("Successfully retrieved {PostCount} posts", posts?.Count() ?? 0);
                return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching all posts");
                return StatusCode(500, "An error occurred while retrieving posts");
            }
        }

        [HttpGet("published")]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPublishedPosts()
        {
            try
            {
                Log.Information("Fetching all published posts");
                var posts = await _postRepository.GetPublishedAsync();
                Log.Information(
                    "Successfully retrieved {PostCount} published posts",
                    posts?.Count() ?? 0
                );
                return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching published posts");
                return StatusCode(500, "An error occurred while retrieving published posts");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostDto>> GetPost(Guid id)
        {
            try
            {
                Log.Information("Fetching post with ID: {PostId}", id);
                var post = await _postRepository.GetByIdAsync(id);
                if (post == null)
                {
                    Log.Warning("Post not found with ID: {PostId}", id);
                    return NotFound();
                }

                // If post is not published, check permissions
                if (!post.IsPublished)
                {
                    if (!(await CanModifyPost(post)))
                    {
                        Log.Warning(
                            "Unauthorized access attempt to unpublished post ID: {PostId} by user: {UserId}",
                            id,
                            CurrentUserId
                        );
                        return Forbid();
                    }
                }

                Log.Information("Successfully retrieved post with ID: {PostId}", id);
                return Ok(_mapper.Map<PostDto>(post));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching post with ID: {PostId}", id);
                return StatusCode(500, "An error occurred while retrieving the post");
            }
        }

        [HttpGet("slug/{slug}")]
        public async Task<ActionResult<PostDto>> GetPostBySlug(string slug)
        {
            try
            {
                Log.Information("Fetching post with slug: {Slug}", slug);
                var post = await _postRepository.GetBySlugAsync(slug);
                if (post == null)
                {
                    Log.Warning("Post not found with slug: {Slug}", slug);
                    return NotFound();
                }

                // If post is not published, check permissions
                if (!post.IsPublished)
                {
                    if (!(await CanModifyPost(post)))
                    {
                        Log.Warning(
                            "Unauthorized access attempt to unpublished post with slug: {Slug} by user: {UserId}",
                            slug,
                            CurrentUserId
                        );
                        return Forbid();
                    }
                }

                Log.Information("Successfully retrieved post with slug: {Slug}", slug);
                return Ok(_mapper.Map<PostDto>(post));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching post with slug: {Slug}", slug);
                return StatusCode(500, "An error occurred while retrieving the post");
            }
        }

        [HttpGet("topic/{topicId}")]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPostsByTopic(Guid topicId)
        {
            try
            {
                Log.Information("Fetching posts for topic ID: {TopicId}", topicId);
                var posts = await _postRepository.GetByTopicIdAsync(topicId);
                Log.Information(
                    "Successfully retrieved {PostCount} posts for topic ID: {TopicId}",
                    posts?.Count() ?? 0,
                    topicId
                );
                return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while fetching posts for topic ID: {TopicId}",
                    topicId
                );
                return StatusCode(500, "An error occurred while retrieving posts");
            }
        }

        [HttpGet("tag/{tagId}")]
        public async Task<ActionResult<IEnumerable<PostDto>>> GetPostsByTag(Guid tagId)
        {
            try
            {
                Log.Information("Fetching posts for tag ID: {TagId}", tagId);
                var posts = await _postRepository.GetByTagIdAsync(tagId);
                Log.Information(
                    "Successfully retrieved {PostCount} posts for tag ID: {TagId}",
                    posts?.Count() ?? 0,
                    tagId
                );
                return Ok(_mapper.Map<IEnumerable<PostDto>>(posts));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while fetching posts for tag ID: {TagId}", tagId);
                return StatusCode(500, "An error occurred while retrieving posts");
            }
        }

        [HttpPost("{id}/view")]
        public async Task<ActionResult<int>> IncrementViewCount(Guid id)
        {
            try
            {
                Log.Information("Incrementing view count for post ID: {PostId}", id);
                var viewCount = await _postRepository.IncrementViewCountAsync(id);
                if (viewCount == 0)
                {
                    Log.Warning(
                        "Post not found while incrementing view count for ID: {PostId}",
                        id
                    );
                    return NotFound();
                }

                Log.Information(
                    "Successfully incremented view count to {ViewCount} for post ID: {PostId}",
                    viewCount,
                    id
                );
                return Ok(viewCount);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "Error occurred while incrementing view count for post ID: {PostId}",
                    id
                );
                return StatusCode(500, "An error occurred while updating the view count");
            }
        }

        [Authorize(Roles = "Admin,SuperAdmin,Editor,Moderator")]
        [HttpPost]
        public async Task<ActionResult<PostDto>> CreatePost(CreatePostCommand command)
        {
            try
            {
                Log.Information("Creating new post with slug: {Slug}", command.Slug);

                if (await _postRepository.SlugExistsAsync(command.Slug))
                {
                    Log.Warning(
                        "Attempted to create post with existing slug: {Slug}",
                        command.Slug
                    );
                    return BadRequest("Slug already exists");
                }

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

                await _postRepository.AddAsync(post);
                Log.Information("Successfully created post with ID: {PostId}", post.Id);
                return CreatedAtAction(
                    nameof(GetPost),
                    new { id = post.Id },
                    _mapper.Map<PostDto>(post)
                );
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while creating post with slug: {Slug}", command.Slug);
                return StatusCode(500, "An error occurred while creating the post");
            }
        }

        [Authorize(Roles = "Admin,SuperAdmin,Editor,Moderator")]
        [HttpPut("{id}")]
        public async Task<ActionResult<PostDto>> UpdatePost(Guid id, UpdatePostCommand command)
        {
            try
            {
                Log.Information("Updating post with ID: {PostId}", id);

                if (id != command.Id)
                {
                    Log.Warning(
                        "ID mismatch while updating post. Path ID: {PathId}, Command ID: {CommandId}",
                        id,
                        command.Id
                    );
                    return BadRequest();
                }

                var existingPost = await _postRepository.GetByIdAsync(id);
                if (existingPost == null)
                {
                    Log.Warning("Post not found for update with ID: {PostId}", id);
                    return NotFound();
                }

                if (!(await CanModifyPost(existingPost)))
                {
                    Log.Warning(
                        "Unauthorized update attempt for post ID: {PostId} by user: {UserId}",
                        id,
                        CurrentUserId
                    );
                    return Forbid();
                }

                if (
                    command.Slug != existingPost.Slug
                    && await _postRepository.SlugExistsAsync(command.Slug)
                )
                {
                    Log.Warning(
                        "Attempted to update post with existing slug: {Slug}",
                        command.Slug
                    );
                    return BadRequest("Slug already exists");
                }

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
                    Log.Information(
                        "Post ID: {PostId} has been published by user: {UserId}",
                        id,
                        CurrentUserId
                    );
                }

                await _postRepository.UpdateAsync(existingPost);
                Log.Information("Successfully updated post with ID: {PostId}", id);
                return Ok(_mapper.Map<PostDto>(existingPost));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while updating post with ID: {PostId}", id);
                return StatusCode(500, "An error occurred while updating the post");
            }
        }

        [Authorize(Roles = "Admin,SuperAdmin,Editor,Moderator")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePost(Guid id)
        {
            try
            {
                Log.Information("Deleting post with ID: {PostId}", id);

                var post = await _postRepository.GetByIdAsync(id);
                if (post == null)
                {
                    Log.Warning("Post not found for deletion with ID: {PostId}", id);
                    return NotFound();
                }

                if (!(await CanDeletePost(post)))
                {
                    Log.Warning(
                        "Unauthorized deletion attempt for post ID: {PostId} by user: {UserId}",
                        id,
                        CurrentUserId
                    );
                    return Forbid();
                }

                post.DeletedBy = CurrentUserId;
                await _postRepository.DeleteAsync(id);
                Log.Information("Successfully deleted post with ID: {PostId}", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error occurred while deleting post with ID: {PostId}", id);
                return StatusCode(500, "An error occurred while deleting the post");
            }
        }
    }
}
