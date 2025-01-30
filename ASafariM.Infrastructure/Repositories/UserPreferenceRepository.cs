using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ASafariM.Infrastructure.Repositories
{
    public class UserPreferenceRepository : IUserPreferenceRepository
    {
        private readonly AppDbContext _dbContext;

        public UserPreferenceRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Core UserPreference Methods
        public async Task<UserPreference?> GetUserPreferenceByIdAsync(Guid userId)
        {
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Theme)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Geography)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Notification)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Privacy)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Accessibility)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Miscellaneous)
                .FirstOrDefaultAsync(p => p.UserId == userId);

            return userPreference;
        }

        public async Task AddUserPreferenceAsync(UserPreference userPreference)
        {
            if (userPreference == null)
            {
                throw new ArgumentNullException(nameof(userPreference), "UserPreference cannot be null.");
            }
            await _dbContext.UserPreferences.AddAsync(userPreference);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUserPreferenceAsync(UserPreference userPreference)
        {
            _dbContext.Entry(userPreference).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        // Accessibility Preferences
        public async Task<AccessibilityPreference?> GetAccessibilityPreferenceAsync(Guid id)
        {
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Accessibility)
                .FirstOrDefaultAsync(up => up.UserId == id);

            return userPreference?.Preference?.Accessibility;
        }

        public async Task UpdateAccessibilityPreferenceAsync(AccessibilityPreference preference)
        {
            if (preference == null)
            {
                throw new ArgumentNullException(nameof(preference), "AccessibilityPreference cannot be null.");
            }
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Accessibility)
                .FirstOrDefaultAsync(up => up.Preference.Accessibility.Id == preference.Id);
            if (userPreference != null)
            {
                userPreference.Preference.Accessibility = preference;
                await UpdateUserPreferenceAsync(userPreference);
            }
        }

        // Geographical Preferences
        public async Task<GeographicalPreference?> GetGeographicalPreferenceAsync(Guid id)
        {
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Geography)
                .FirstOrDefaultAsync(up => up.UserId == id);

            return userPreference?.Preference?.Geography;
        }

        public async Task UpdateGeographicalPreferenceAsync(GeographicalPreference preference)
        {
            if (preference == null)
            {
                throw new ArgumentNullException(nameof(preference), "GeographicalPreference cannot be null.");
            }
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Geography)
                .FirstOrDefaultAsync(up => up.Preference.Geography.Id == preference.Id);
            if (userPreference != null)
            {
                userPreference.Preference.Geography = preference;
                await UpdateUserPreferenceAsync(userPreference);
            }
        }

        // Notification Preferences
        public async Task<NotificationPreference?> GetNotificationPreferenceAsync(Guid id)
        {
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Notification)
                .FirstOrDefaultAsync(up => up.UserId == id);

            return userPreference?.Preference?.Notification;
        }

        public async Task UpdateNotificationPreferenceAsync(NotificationPreference preference)
        {
            if (preference == null)
            {
                throw new ArgumentNullException(nameof(preference), "NotificationPreference cannot be null.");
            }
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Notification)
                .FirstOrDefaultAsync(up => up.Preference.Notification.Id == preference.Id);
            if (userPreference != null)
            {
                userPreference.Preference.Notification = preference;
                await UpdateUserPreferenceAsync(userPreference);
            }
        }

        // Miscellaneous Preferences
        public async Task<MiscellaneousPreference?> GetMiscellaneousPreferenceAsync(Guid id)
        {
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Miscellaneous)
                .FirstOrDefaultAsync(up => up.UserId == id);

            return userPreference?.Preference?.Miscellaneous;
        }

        public async Task UpdateMiscellaneousPreferenceAsync(MiscellaneousPreference preference)
        {
            if (preference == null)
            {
                throw new ArgumentNullException(nameof(preference), "MiscellaneousPreference cannot be null.");
            }
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Miscellaneous)
                .FirstOrDefaultAsync(up => up.Preference.Miscellaneous.Id == preference.Id);
            if (userPreference != null)
            {
                userPreference.Preference.Miscellaneous = preference;
                await UpdateUserPreferenceAsync(userPreference);
            }
        }

        // Language Preferences
        public async Task<LanguagePreference?> GetLanguagePreferenceAsync(Guid id)
        {
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Language)
                .FirstOrDefaultAsync(up => up.UserId == id);

            return userPreference?.Preference?.Language;
        }

        public async Task UpdateLanguagePreferenceAsync(LanguagePreference preference)
        {
            if (preference == null)
            {
                throw new ArgumentNullException(nameof(preference), "LanguagePreference cannot be null.");
            }
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Language)
                .FirstOrDefaultAsync(up => up.Preference.Language.Id == preference.Id);
            if (userPreference != null)
            {
                userPreference.Preference.Language = preference;
                await UpdateUserPreferenceAsync(userPreference);
            }
        }

        // Privacy Preferences
        public async Task<PrivacyPreference?> GetPrivacyPreferenceAsync(Guid id)
        {
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Privacy)
                .FirstOrDefaultAsync(up => up.UserId == id);

            return userPreference?.Preference?.Privacy;
        }

        public async Task UpdatePrivacyPreferenceAsync(PrivacyPreference preference)
        {
            if (preference == null)
            {
                throw new ArgumentNullException(nameof(preference), "PrivacyPreference cannot be null.");
            }
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Privacy)
                .FirstOrDefaultAsync(up => up.Preference.Privacy.Id == preference.Id);
            if (userPreference != null)
            {
                userPreference.Preference.Privacy = preference;
                await UpdateUserPreferenceAsync(userPreference);
            }
        }

        // Theme Preferences
        public async Task<ThemePreference?> GetThemePreferenceAsync(Guid id)
        {
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Theme)
                .FirstOrDefaultAsync(up => up.UserId == id);

            return userPreference?.Preference?.Theme;
        }

        public async Task UpdateThemePreferenceAsync(ThemePreference preference)
        {
            if (preference == null)
            {
                throw new ArgumentNullException(nameof(preference), "ThemePreference cannot be null.");
            }
            var userPreference = await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Theme)
                .FirstOrDefaultAsync(up => up.Preference.Theme.Id == preference.Id);
            if (userPreference != null)
            {
                userPreference.Preference.Theme = preference;
                await UpdateUserPreferenceAsync(userPreference);
            }
        }

        // Generic Repository Methods
        public async Task<IEnumerable<UserPreference>> GetAllAsync()
        {
            return await _dbContext.UserPreferences
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Theme)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Geography)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Notification)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Privacy)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Accessibility)
                .Include(up => up.Preference)
                    .ThenInclude(p => p.Miscellaneous)
                .ToListAsync();
        }

        public async Task<UserPreference?> DeleteAsync(Guid id)
        {
            var preference = await GetUserPreferenceByIdAsync(id);
            if (preference != null)
            {
                _dbContext.UserPreferences.Remove(preference);
                await _dbContext.SaveChangesAsync();
            }
            return preference;
        }
    }
}
