namespace ASafariM.Application.DTOs
{
    public class UserPreferenceDto
    {
        public Guid Id { get; set; }
        public ThemePreferenceDto? Theme { get; set; }
        public GeographicalPreferenceDto? Geography { get; set; }
        public NotificationPreferenceDto? Notification { get; set; }
        public LanguagePreferenceDto? Language { get; set; }
        public PrivacyPreferenceDto? Privacy { get; set; }
        public AccessibilityPreferenceDto? Accessibility { get; set; }
        public MiscellaneousPreferenceDto? Miscellaneous { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public object DateUpdated { get; internal set; }
    }
}
