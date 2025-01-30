using System.Security.Claims;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ASafariM.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserPreferencesController : ControllerBase
    {
        private readonly IUserPreferenceRepository _userPreferenceRepository;
        private readonly ILogger<UserPreferencesController> _logger;

        public UserPreferencesController(
            IUserPreferenceRepository userPreferenceRepository,
            ILogger<UserPreferencesController> logger
        )
        {
            _userPreferenceRepository = userPreferenceRepository;
            _logger = logger;
        }

        /// <summary>
        /// Get the current user's preferences.
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetUserPreferencesAsync()
        {
            try
            {
                Guid userId = GetCurrentUserId();

                var userPreferences = await _userPreferenceRepository.GetUserPreferenceByIdAsync(
                    userId
                );
                if (userPreferences == null)
                {
                    return NotFound("User preferences not found.");
                }

                return Ok(userPreferences);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve user preferences.");
                return StatusCode(500, "An error occurred while retrieving user preferences.");
            }
        }

        /// <summary>
        /// Update ThemePreferences for the current user.
        /// </summary>
        [HttpPut("theme")]
        public async Task<IActionResult> UpdateThemePreferenceAsync(
            [FromBody] ThemePreference themePreference
        )
        {
            return await UpdateUserPreferenceAsync(userPreferences =>
            {
                userPreferences.Preference.Theme = themePreference;
            });
        }

        /// <summary>
        /// Update GeographicalPreferences for the current user.
        /// </summary>
        [HttpPut("geographical")]
        public async Task<IActionResult> UpdateGeographicalPreferenceAsync(
            [FromBody] GeographicalPreference geographicalPreference
        )
        {
            return await UpdateUserPreferenceAsync(userPreferences =>
            {
                userPreferences.Preference.Geography = geographicalPreference;
            });
        }

        /// <summary>
        /// Update NotificationPreferences for the current user.
        /// </summary>
        [HttpPut("notification")]
        public async Task<IActionResult> UpdateNotificationPreferenceAsync(
            [FromBody] NotificationPreference notificationPreference
        )
        {
            return await UpdateUserPreferenceAsync(userPreferences =>
            {
                userPreferences.Preference.Notification = notificationPreference;
            });
        }

        /// <summary>
        /// Update MiscellaneousPreferences for the current user.
        /// </summary>
        [HttpPut("miscellaneous")]
        public async Task<IActionResult> UpdateMiscellaneousPreferenceAsync(
            [FromBody] MiscellaneousPreference miscellaneousPreference
        )
        {
            return await UpdateUserPreferenceAsync(userPreferences =>
            {
                userPreferences.Preference.Miscellaneous = miscellaneousPreference;
            });
        }

        /// <summary>
        /// Update PrivacyPreferences for the current user.
        /// </summary>
        [HttpPut("privacy")]
        public async Task<IActionResult> UpdatePrivacyPreferenceAsync(
            [FromBody] PrivacyPreference privacyPreference
        )
        {
            return await UpdateUserPreferenceAsync(userPreferences =>
            {
                userPreferences.Preference.Privacy = privacyPreference;
            });
        }

        /// <summary>
        /// Update AccessibilityPreferences for the current user.
        /// </summary>
        [HttpPut("accessibility")]
        public async Task<IActionResult> UpdateAccessibilityPreferenceAsync(
            [FromBody] AccessibilityPreference accessibilityPreference
        )
        {
            return await UpdateUserPreferenceAsync(userPreferences =>
            {
                userPreferences.Preference.Accessibility = accessibilityPreference;
            });
        }

        private async Task<IActionResult> UpdateUserPreferenceAsync(
            Action<UserPreference> updateAction
        )
        {
            try
            {
                Guid userId = GetCurrentUserId();

                var userPreferences = await _userPreferenceRepository.GetUserPreferenceByIdAsync(
                    userId
                );
                if (userPreferences == null)
                {
                    userPreferences = new UserPreference
                    {
                        UserId = userId,
                        CreatedAt = DateTime.UtcNow,
                        Preference = new Preference()
                    };
                    updateAction(userPreferences);
                    await _userPreferenceRepository.AddUserPreferenceAsync(userPreferences);
                }
                else
                {
                    updateAction(userPreferences);
                    userPreferences.UpdatedAt = DateTime.UtcNow;
                    await _userPreferenceRepository.UpdateUserPreferenceAsync(userPreferences);
                }

                return Ok("User preferences updated successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to update user preferences.");
                return StatusCode(500, "An error occurred while updating user preferences.");
            }
        }

        private Guid GetCurrentUserId()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim == null || !Guid.TryParse(userIdClaim.Value, out Guid userId))
            {
                _logger.LogError("Failed to retrieve valid User ID from claims.");
                throw new UnauthorizedAccessException("Invalid or missing User ID claim.");
            }
            return userId;
        }
    }
}
