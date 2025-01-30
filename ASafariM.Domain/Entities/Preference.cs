using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class Preference
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        // Preference settings
        public ThemePreference? Theme { get; set; }
        public GeographicalPreference? Geography { get; set; }
        public NotificationPreference? Notification { get; set; }
        public LanguagePreference? Language { get; set; }
        public PrivacyPreference? Privacy { get; set; }
        public AccessibilityPreference? Accessibility { get; set; }
        public MiscellaneousPreference? Miscellaneous { get; set; }

        // Navigation properties
        public ICollection<UserPreference>? UserPreferences { get; set; }

        // Status
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; } = true;

        // Audit fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
