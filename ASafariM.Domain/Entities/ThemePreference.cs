using System.ComponentModel.DataAnnotations;
using ASafariM.Domain.Enums;
using ASafariM.Domain.Interfaces;

namespace ASafariM.Domain.Entities
{
    public class ThemePreference
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsDarkTheme { get; set; } = false;
        public required string FontSize { get; set; } = "14px";
        public required LanguagePreference Language { get; set; }
        public required string AccentColor { get; set; } = "#FF0000";
    }
}
