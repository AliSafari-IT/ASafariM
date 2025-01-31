using System;

namespace ASafariM.Domain.Entities
{
    public class PostTag
    {
        public Guid PostId { get; set; }
        public Guid TagId { get; set; }

        // Navigation properties
        public Post? Post { get; set; }
        public Tag? Tag { get; set; }
    }
}
