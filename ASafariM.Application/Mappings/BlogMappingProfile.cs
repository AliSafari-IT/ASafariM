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

            // Tag mappings
            CreateMap<CreateTagCommand, Tag>();
            CreateMap<UpdateTagCommand, Tag>();

            // Post mappings
            CreateMap<CreatePostCommand, Post>();
            CreateMap<UpdatePostCommand, Post>();

            // SitemapItem mappings
            CreateMap<SitemapItem, SitemapItemDto>();
            CreateMap<CreateSitemapItemCommand, SitemapItem>();
            CreateMap<UpdateSitemapItemCommand, SitemapItem>();
        }
    }
}
