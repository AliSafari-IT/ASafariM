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
            CreateMap<Preference, PreferenceDto>();

            CreateMap<User, UserInfoDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.IsAdmin, opt => opt.MapFrom(src => src.IsAdmin))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Biography, opt => opt.MapFrom(src => src.Biography))
                .ForMember(
                    dest => dest.ProfilePicture,
                    opt => opt.MapFrom(src => src.ProfilePicture)
                )
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.LastLogin, opt => opt.MapFrom(src => src.LastLogin))
                .ReverseMap();

            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.IsAdmin, opt => opt.MapFrom(src => src.IsAdmin))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                .ForMember(dest => dest.LastLogin, opt => opt.MapFrom(src => src.LastLogin))
                .ForMember(dest => dest.Biography, opt => opt.MapFrom(src => src.Biography))
                .ForMember(
                    dest => dest.ProfilePicture,
                    opt => opt.MapFrom(src => src.ProfilePicture)
                )
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                .ForMember(dest => dest.Remark, opt => opt.MapFrom(src => src.Remark))
                .ForMember(dest => dest.Preferences, opt => opt.MapFrom(src => src.Preferences))
                .ReverseMap();

            CreateMap<UserInfoDto, UserDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.IsAdmin, opt => opt.MapFrom(src => src.IsAdmin))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.LastLogin, opt => opt.MapFrom(src => src.LastLogin))
                .ForMember(dest => dest.Biography, opt => opt.MapFrom(src => src.Biography))
                .ForMember(
                    dest => dest.ProfilePicture,
                    opt => opt.MapFrom(src => src.ProfilePicture)
                )
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                .ReverseMap();

            CreateMap<UserPreference, UserPreferenceDto>()
                .ForMember(
                    dest => dest.Id,
                    opt =>
                        opt.MapFrom(src => src.Preference != null ? src.Preference.Id : Guid.Empty)
                )
                .ForMember(
                    dest => dest.Theme,
                    opt => opt.MapFrom(src => src.Preference != null ? src.Preference.Theme : null)
                )
                .ForMember(
                    dest => dest.Geography,
                    opt =>
                        opt.MapFrom(src => src.Preference != null ? src.Preference.Geography : null)
                )
                .ForMember(
                    dest => dest.Notification,
                    opt =>
                        opt.MapFrom(src =>
                            src.Preference != null ? src.Preference.Notification : null
                        )
                )
                .ForMember(
                    dest => dest.Language,
                    opt =>
                        opt.MapFrom(src => src.Preference != null ? src.Preference.Language : null)
                )
                .ForMember(
                    dest => dest.Privacy,
                    opt =>
                        opt.MapFrom(src => src.Preference != null ? src.Preference.Privacy : null)
                )
                .ForMember(
                    dest => dest.Accessibility,
                    opt =>
                        opt.MapFrom(src =>
                            src.Preference != null ? src.Preference.Accessibility : null
                        )
                )
                .ForMember(
                    dest => dest.Miscellaneous,
                    opt =>
                        opt.MapFrom(src =>
                            src.Preference != null ? src.Preference.Miscellaneous : null
                        )
                )
                .ForMember(
                    dest => dest.DateCreated,
                    opt => opt.MapFrom(src => src.Preference.CreatedAt)
                )
                .ReverseMap();

            CreateMap<Role, UserRoleDto>()
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Name))
                .ReverseMap();

            CreateMap<UserRole, UserRoleDto>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId))
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role.Name))
                .ReverseMap();
        }
    }
}
