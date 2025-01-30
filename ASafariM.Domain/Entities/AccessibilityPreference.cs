using System.ComponentModel.DataAnnotations;

namespace ASafariM.Domain.Entities
{
    public class AccessibilityPreference
    {
        [Key]
        public Guid Id { get; set; }
        public bool EnableHighContrastMode { get; set; }
        public bool EnableScreenReaderSupport { get; set; }
        public int TextScalingFactor { get; set; } = 100; // Percentage, default is 100%
    }
}
