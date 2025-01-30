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
                .ForMember(
                    dest => dest.Preferences,
                    opt =>
                        opt.MapFrom(src =>
                            src.Preferences != null && src.Preferences.Any()
                                ? src
                                    .Preferences.Select(p => new UserPreferenceDto
                                    {
                                        Id = p.Preference != null ? p.Preference.Id : Guid.Empty,
                                        Theme = p.Preference != null ? p.Preference.Theme : null,
                                        Geography = p.Preference != null ? p.Preference.Geography : null,
                                        Notification = p.Preference != null ? p.Preference.Notification : null,
                                        Language = p.Preference != null ? p.Preference.Language : null,
                                        Privacy = p.Preference != null ? p.Preference.Privacy : null,
                                        Accessibility = p.Preference != null ? p.Preference.Accessibility : null,
                                        Miscellaneous = p.Preference != null ? p.Preference.Miscellaneous : null,
                                        DateCreated = p.Preference != null ? p.Preference.CreatedAt : DateTime.UtcNow,
                                        LastUpdated = p.Preference != null ? (p.Preference.UpdatedAt ?? DateTime.UtcNow) : DateTime.UtcNow
                                    })
                                    .ToList()
                                : null
                        )
                )
                .ReverseMap();

            CreateMap<UserInfoDto, UserDto>()
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

            CreateMap<UserPreference, UserPreferenceDto>()
                .ForMember(dest => dest.Theme, opt => opt.MapFrom(src => src.Preference.Theme))
                .ForMember(
                    dest => dest.Geography,
                    opt => opt.MapFrom(src => src.Preference.Geography)
                )
                .ForMember(
                    dest => dest.Notification,
                    opt => opt.MapFrom(src => src.Preference.Notification)
                )
                .ForMember(
                    dest => dest.Language,
                    opt => opt.MapFrom(src => src.Preference.Language)
                )
                .ForMember(dest => dest.Privacy, opt => opt.MapFrom(src => src.Preference.Privacy))
                .ForMember(
                    dest => dest.Accessibility,
                    opt => opt.MapFrom(src => src.Preference.Accessibility)
                )
                .ForMember(
                    dest => dest.Miscellaneous,
                    opt => opt.MapFrom(src => src.Preference.Miscellaneous)
                )
                .ReverseMap();

            CreateMap<ThemePreference, ThemePreferenceDto>().ReverseMap();
            CreateMap<GeographicalPreference, GeographicalPreferenceDto>().ReverseMap();
            CreateMap<NotificationPreference, NotificationPreferenceDto>().ReverseMap();
            CreateMap<LanguagePreference, LanguagePreferenceDto>().ReverseMap();
            CreateMap<PrivacyPreference, PrivacyPreferenceDto>().ReverseMap();
            CreateMap<AccessibilityPreference, AccessibilityPreferenceDto>().ReverseMap();
            CreateMap<MiscellaneousPreference, MiscellaneousPreferenceDto>().ReverseMap();

            CreateMap<Preference, UserPreferenceDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Theme, opt => opt.MapFrom(src => src.Theme))
                .ForMember(dest => dest.Geography, opt => opt.MapFrom(src => src.Geography))
                .ForMember(dest => dest.Notification, opt => opt.MapFrom(src => src.Notification))
                .ForMember(dest => dest.Language, opt => opt.MapFrom(src => src.Language))
                .ForMember(dest => dest.Privacy, opt => opt.MapFrom(src => src.Privacy))
                .ForMember(dest => dest.Accessibility, opt => opt.MapFrom(src => src.Accessibility))
                .ForMember(dest => dest.Miscellaneous, opt => opt.MapFrom(src => src.Miscellaneous))
                .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => src.CreatedAt))
                .ForMember(dest => dest.LastUpdated, opt => opt.MapFrom(src => src.UpdatedAt))
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
                .ForMember(
                    dest => dest.Preferences,
                    opt =>
                        opt.MapFrom(src =>
                            src.Preferences != null && src.Preferences.Any()
                                ? src
                                    .Preferences.Select(p => new UserPreferenceDto
                                    {
                                        Id = p.Preference != null ? p.Preference.Id : Guid.Empty,
                                        Theme = p.Preference != null ? p.Preference.Theme : null,
                                        Geography = p.Preference != null ? p.Preference.Geography : null,
                                        Notification = p.Preference != null ? p.Preference.Notification : null,
                                        Language = p.Preference != null ? p.Preference.Language : null,
                                        Privacy = p.Preference != null ? p.Preference.Privacy : null,
                                        Accessibility = p.Preference != null ? p.Preference.Accessibility : null,
                                        Miscellaneous = p.Preference != null ? p.Preference.Miscellaneous : null,
                                        DateCreated = p.Preference != null ? p.Preference.CreatedAt : DateTime.UtcNow,
                                        LastUpdated = p.Preference != null ? (p.Preference.UpdatedAt ?? DateTime.UtcNow) : DateTime.UtcNow
                                    })
                                    .ToList()
                                : null
                        )
                )
                .ReverseMap();

            // Add mapping for Role to UserRoleDto
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
