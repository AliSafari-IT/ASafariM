using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using AutoMapper;

namespace ASafariM.Application.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MarkdownFile, MarkdownFileResponseDto>();

            CreateMap<MarkdownFileUser, ContributorDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User.LastName))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.UserName))
                .ForMember(dest => dest.PenName, opt => opt.MapFrom(src => src.User.PenName))
                .ForMember(
                    dest => dest.ProfilePicture,
                    opt => opt.MapFrom(src => src.User.ProfilePicture)
                )
                .ForMember(dest => dest.IsAdmin, opt => opt.MapFrom(src => src.User.IsAdmin));

            CreateMap<ThemePreference, ThemePreferenceDto>();
            CreateMap<GeographicalPreference, GeographicalPreferenceDto>();
            CreateMap<NotificationPreference, NotificationPreferenceDto>();
            CreateMap<PrivacyPreference, PrivacyPreferenceDto>();
            CreateMap<AccessibilityPreference, AccessibilityPreferenceDto>();
            CreateMap<MiscellaneousPreference, MiscellaneousPreferenceDto>();
            CreateMap<LanguagePreference, LanguagePreferenceDto>();

            CreateMap<CreateMarkdownFileDto, MarkdownFile>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());
        }
    }
}
