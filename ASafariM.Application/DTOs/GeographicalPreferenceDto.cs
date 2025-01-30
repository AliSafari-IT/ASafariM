using ASafariM.Domain.Entities;

namespace ASafariM.Application.DTOs
{
    public class GeographicalPreferenceDto
    {
        public string? Country { get; set; }
        public string? Currency { get; set; }
        public string? TimeZone { get; set; }
        public string? DateFormat { get; set; }

        public static implicit operator GeographicalPreferenceDto?(GeographicalPreference? v)
        {
            if (v == null)
                return null;
            return new GeographicalPreferenceDto
            {
                Country = v.Country?.Name,
                Currency = v.Currency?.Name,
                TimeZone = v.TimeZone?.Name,
                DateFormat = v.DateFormat?.DisplayName,
            };
        }
    }
}
