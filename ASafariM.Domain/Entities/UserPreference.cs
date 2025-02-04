using System;
using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class UserPreference
    {
        [Key]
        public Guid Id { get; set; }

        // Foreign keys
        public Guid UserId { get; set; }
        public Guid PreferenceId { get; set; }

        // Navigation properties
        public User User { get; set; } = null!;
        public Preference Preference { get; set; } = null!;

        // Status
        public bool IsActive { get; set; } = true;

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
