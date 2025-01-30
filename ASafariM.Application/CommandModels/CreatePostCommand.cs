using System;
using System.Collections.Generic;

namespace ASafariM.Application.CommandModels
{
    public class CreatePostCommand
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string Excerpt { get; set; }
        public string Slug { get; set; }
        public Guid TopicId { get; set; }
        public int DifficultyLevel { get; set; }
        public bool IsPublished { get; set; }
        public string ImageUrl { get; set; }
        public string MetaDescription { get; set; }
        public ICollection<Guid> TagIds { get; set; }
    }

    public class UpdatePostCommand : CreatePostCommand
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
    }
}
