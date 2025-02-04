using System;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;

namespace ASafariM.Application.DTOs
{
    public class PreferenceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        // Preference settings
        public ThemePreferenceDto? Theme { get; set; }
        public GeographicalPreferenceDto? Geography { get; set; }
        public NotificationPreferenceDto? Notification { get; set; }
        public LanguagePreferenceDto? Language { get; set; }
        public PrivacyPreferenceDto? Privacy { get; set; }
        public AccessibilityPreferenceDto? Accessibility { get; set; }
        public MiscellaneousPreferenceDto? Miscellaneous { get; set; }

        // Status
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }

        // Audit fields
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
