using System;
using System.Collections.Generic;

namespace ASafariM.Application.CommandModels
{
    public class CreatePostCommand
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Excerpt { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public Guid TopicId { get; set; } = Guid.NewGuid();
        public int DifficultyLevel { get; set; } = 1;
        public bool IsPublished { get; set; } = false;
        public string ImageUrl { get; set; } = string.Empty;
        public string MetaDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<Guid> TagIds { get; set; } = new List<Guid>();
    }

    public class UpdatePostCommand : CreatePostCommand
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
    }
}
