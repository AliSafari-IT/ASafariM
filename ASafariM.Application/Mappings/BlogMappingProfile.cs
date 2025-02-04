using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using AutoMapper;

namespace ASafariM.Application.Mappings
{
    public class BlogMappingProfile : Profile
    {
        public BlogMappingProfile()
        {
            // Topic mappings
            CreateMap<CreateTopicCommand, Topic>();
            CreateMap<UpdateTopicCommand, Topic>();
            CreateMap<Topic, TopicDto>();

            // Tag mappings
            CreateMap<CreateTagCommand, Tag>();
            CreateMap<UpdateTagCommand, Tag>();
            CreateMap<Tag, TagDto>()
                .ForMember(dest => dest.Slug, opt => opt.MapFrom(src => src.Slug))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            // Post mappings
            CreateMap<CreatePostCommand, Post>();
            CreateMap<UpdatePostCommand, Post>();

            // SitemapItem mappings
            CreateMap<SitemapItem, SitemapItemDto>();
            CreateMap<CreateSitemapItemCommand, SitemapItem>();
            CreateMap<UpdateSitemapItemCommand, SitemapItem>();

            // User mappings
            CreateMap<CreateUserCommand, User>();

            // Role mappings
            CreateMap<Role, RoleDto>();

            // UserPreference mappings
            CreateMap<UserPreference, UserPreferenceDto>();

            // GeographicalPreference mappings
            CreateMap<GeographicalPreference, GeographicalPreferenceDto>();
            CreateMap<GeographicalPreferenceDto, GeographicalPreference>();
        }
    }
}
