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

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string? Description { get; set; }

        public string? Slug { get; set; }

        public Guid? ParentTopicId { get; set; }

        [ForeignKey("ParentTopicId")]
        public virtual Topic? ParentTopic { get; set; }
    }
}