using System;
using System.Collections.Generic;

namespace ASafariM.Domain.Entities
{
    public class Post
    {
        public Post()
        {
            PostTags = new HashSet<PostTag>();
            IsDeleted = false;
            DeletedAt = null;
            DeletedBy = null;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string Excerpt { get; set; }
        public string Slug { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Author { get; set; }
        public int ViewCount { get; set; }
        public Guid TopicId { get; set; }
        public int DifficultyLevel { get; set; }
        public bool IsPublished { get; set; }
        public string ImageUrl { get; set; }
        public string MetaDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }

        // Navigation properties
        public Topic Topic { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
    }
}
