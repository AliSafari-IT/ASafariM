using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using AutoMapper;

namespace ASafariM.Application.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<ThemePreference, ThemePreferenceDto>();
            CreateMap<GeographicalPreference, GeographicalPreferenceDto>();
            CreateMap<NotificationPreference, NotificationPreferenceDto>();
            CreateMap<LanguagePreference, LanguagePreferenceDto>();
            CreateMap<PrivacyPreference, PrivacyPreferenceDto>();
            CreateMap<AccessibilityPreference, AccessibilityPreferenceDto>();
            CreateMap<MiscellaneousPreference, MiscellaneousPreferenceDto>();

            CreateMap<User, UserInfoDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserInfoDto, UserDto>().ReverseMap();
            CreateMap<Role, UserRoleDto>().ReverseMap();
            CreateMap<UserRole, UserRoleDto>()
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role.Name))
                .ReverseMap();
        }
    }
}
