using System;
using System.Collections.Generic;

namespace ASafariM.Domain.Entities
{
    public class Tag
    {
        public Tag()
        {
            PostTags = new HashSet<PostTag>();
            IsDeleted = false;
            DeletedAt = null;
            DeletedBy = null;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }

        // Navigation property
        public ICollection<PostTag> PostTags { get; set; }
    }
}
