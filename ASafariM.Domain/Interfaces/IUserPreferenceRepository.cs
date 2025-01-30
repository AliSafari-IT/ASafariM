using ASafariM.Domain.Entities;

namespace ASafariM.Domain.Interfaces
{
    public interface IUserPreferenceRepository
    {
        // Core UserPreference Methods
        Task<UserPreference?> GetUserPreferenceByIdAsync(Guid userId); // Fetch a UserPreference by UserId
        Task AddUserPreferenceAsync(UserPreference userPreference);   // Add a new UserPreference
        Task UpdateUserPreferenceAsync(UserPreference userPreference); // Update an existing UserPreference

        // Accessibility Preferences
        Task<AccessibilityPreference?> GetAccessibilityPreferenceAsync(Guid id);
        Task UpdateAccessibilityPreferenceAsync(AccessibilityPreference preference);

        // Geographical Preferences
        Task<GeographicalPreference?> GetGeographicalPreferenceAsync(Guid id);
        Task UpdateGeographicalPreferenceAsync(GeographicalPreference preference);

        // Notification Preferences
        Task<NotificationPreference?> GetNotificationPreferenceAsync(Guid id);
        Task UpdateNotificationPreferenceAsync(NotificationPreference preference);

        // Miscellaneous Preferences
        Task<MiscellaneousPreference?> GetMiscellaneousPreferenceAsync(Guid id);
        Task UpdateMiscellaneousPreferenceAsync(MiscellaneousPreference preference);

        // Theme Preferences
        Task<ThemePreference?> GetThemePreferenceAsync(Guid id);
        Task UpdateThemePreferenceAsync(ThemePreference preference);

        // Language Preferences
        Task<LanguagePreference?> GetLanguagePreferenceAsync(Guid id);
        Task UpdateLanguagePreferenceAsync(LanguagePreference preference);

        // Privacy Preferences
        Task<PrivacyPreference?> GetPrivacyPreferenceAsync(Guid id);
        Task UpdatePrivacyPreferenceAsync(PrivacyPreference preference);
    }
}
