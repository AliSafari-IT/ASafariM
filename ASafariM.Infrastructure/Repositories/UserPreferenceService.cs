using ASafariM.Application.Services;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;

namespace ASafariM.Infrastructure.Repositories
{
    public class UserPreferenceService : IUserPreferenceService
    {
        public string GetPreference(string key)
        {
            var value = "";
            return value;
        }

        public void SetPreference(string key, string value)
        {
            var languagePreference = new LanguagePreference { Language = LanguageEnum.en_US };
            
            var preference = new Preference
            {
                Name = key,
                Theme = new ThemePreference 
                { 
                    FontSize = "14px", 
                    AccentColor = "#FF0000", 
                    Language = languagePreference 
                },
                Geography = new GeographicalPreference(),
                Notification = new NotificationPreference(),
                Language = languagePreference,
                Privacy = new PrivacyPreference(),
                Accessibility = new AccessibilityPreference(),
                Miscellaneous = new MiscellaneousPreference()
            };

            var userPreference = new UserPreference
            {
                Preference = preference,
                IsActive = true
            };
        }
    }
}
