using System;
using System.Collections.Generic;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.DTOs
{
    public class PostDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Summary { get; set; }
        public string? Excerpt { get; set; }
        public string? Slug { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string? Author { get; set; }
        public Guid TopicId { get; set; }
        public string? TopicName { get; set; }
        public int? DifficultyLevel { get; set; }
        public bool IsPublished { get; set; } = false;
        public bool IsDraft { get; set; } = true;
        public string? ImageUrl { get; set; }
        public string? MetaDescription { get; set; }
        public ICollection<Tag>? Tags { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int PostCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public int Rating { get; set; } = 0;
        public int RatingCount { get; set; } = 0;
        public bool IsActive { get; set; } = true;
        public int ViewCount { get; set; } = 0;
    }
}
