using ASafariM.Application.Mappings;
using ASafariM.Application.Services;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using ASafariM.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace ASafariM.Api
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            var services = builder.Services;

            // Register repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserPreferenceRepository, UserPreferenceRepository>();
            services.AddScoped<IGenericRepository<Role>, GenericRepository<Role>>();
            services.AddScoped<IGenericRepository<MarkdownFile>, GenericRepository<MarkdownFile>>();
            // Register new blog-related repositories
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITopicRepository, TopicRepository>();
            services.AddScoped<ISitemapItemRepository, SitemapItemRepository>();

            // Register services
            services.AddScoped<RoleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserPreferenceService, UserPreferenceService>();
            services.AddScoped<IMarkdownFilesService, MarkdownFilesService>();
            services.AddScoped<JwtTokenService>();

            // Register AutoMapper profiles
            services.AddAutoMapper(typeof(UserMappingProfile).Assembly);
        }
    }
}
