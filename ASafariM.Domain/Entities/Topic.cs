using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASafariM.Domain.Entities
{
    public class Topic
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Slug { get; set; }
        public Guid? ParentTopicId { get; set; }
        public virtual Topic? ParentTopic { get; set; }
        public virtual ICollection<Topic>? ChildTopics { get; set; } = new List<Topic>();
        public virtual ICollection<Post>? Posts { get; set; } = new List<Post>();
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid? DeletedBy { get; set; }

    }
}
