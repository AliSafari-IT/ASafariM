using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Summary { get; set; }
        public string? Excerpt { get; set; }
        public string? Slug { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string? Author { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public Tag[]? Tags { get; set; }
        public Category[]? Categories { get; set; }
        public User[]? Authors { get; set; }
        public User[]? Collaborators { get; set; }
        public Comment[]? Comments { get; set; }
        public Attachment[]? Attachments { get; set; }
        public Link[]? Links { get; set; }
        public Post[]? RelatedPosts { get; set; }
        public bool IsPublished { get; set; } = true;
        public bool IsDraft { get; set; } = false;
        public string? ImageUrl { get; set; }
        public string? VideoUrl { get; set; }
        public string[]? AudioUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; } = null;
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public StatusEnum Status { get; set; }
        public string? StatusMessage { get; set; }
        public string? StatusColor { get; set; }
        public string? StatusIcon { get; set; }
        public string? StatusTooltip { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
        public string? DeletedMessage { get; set; }
    }
}
