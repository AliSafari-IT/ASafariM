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
            CreateMap<Topic, TopicDto>()
                .ForMember(
                    dest => dest.ParentTopicName,
                    opt => opt.MapFrom(src => src.ParentTopic != null ? src.ParentTopic.Name : null)
                )
                .ForMember(dest => dest.PostCount, opt => opt.MapFrom(src => src.Posts.Count));
            CreateMap<CreateTopicCommand, Topic>();
            CreateMap<UpdateTopicCommand, Topic>();

            // Tag mappings
            CreateMap<Tag, TagDto>()
                .ForMember(dest => dest.PostCount, opt => opt.MapFrom(src => src.PostTags.Count));
            CreateMap<CreateTagCommand, Tag>();
            CreateMap<UpdateTagCommand, Tag>();

            // Post mappings
            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.TopicName, opt => opt.MapFrom(src => src.Topic.Name))
                .ForMember(
                    dest => dest.Tags,
                    opt => opt.MapFrom(src => src.PostTags.Select(pt => pt.Tag))
                );
            CreateMap<CreatePostCommand, Post>();
            CreateMap<UpdatePostCommand, Post>();

            // SitemapItem mappings
            CreateMap<SitemapItem, SitemapItemDto>();
            CreateMap<CreateSitemapItemCommand, SitemapItem>();
            CreateMap<UpdateSitemapItemCommand, SitemapItem>();
        }
    }
}
