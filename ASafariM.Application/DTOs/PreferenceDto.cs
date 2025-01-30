using System;
using ASafariM.Domain.Entities;

namespace ASafariM.Application.DTOs
{
    public class ThemePreferenceDto
    {
        public bool IsDarkTheme { get; set; }
        public string? FontSize { get; set; }
        public string? AccentColor { get; set; }
        public LanguagePreferenceDto? Language { get; set; }

        public static implicit operator ThemePreferenceDto?(ThemePreference? v)
        {
            if (v == null)
                return null;
            return new ThemePreferenceDto
            {
                IsDarkTheme = v.IsDarkTheme,
                FontSize = v.FontSize,
                AccentColor = v.AccentColor,
                Language = v.Language,
            };
        }
    }
}
