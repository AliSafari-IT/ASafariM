using ASafariM.Api;
using ASafariM.Application;
using ASafariM.Application.Mappings;
using ASafariM.Application.Services;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure;
using ASafariM.Infrastructure.Persistence;
using ASafariM.Infrastructure.Repositories;
using ASafariM.Infrastructure.Services;
using ASafariM.Presentation;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;

// Add DbContext
services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 31)), // Adjust version as needed
        mySqlOptions =>
            mySqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5, // Number of retry attempts
                maxRetryDelay: TimeSpan.FromSeconds(10), // Maximum delay between retries
                errorNumbersToAdd: null // Additional error codes to consider transient
            )
    )
);

// Call the RegisterServices method
ServiceRegistration.RegisterServices(builder);

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowFrontend",
        builder =>
        {
            builder
                .WithOrigins(
                    "http://localhost:5173",
                    "http://localhost:3000",
                    "asafarim.com",
                    "https://www.asafarim.com"
                ) // Frontend URL
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
        }
    );
});

// Register AutoMapper with all profiles
services.AddAutoMapper(cfg =>
{
    cfg.AddMaps(new[] { typeof(UserMappingProfile).Assembly, typeof(AutoMapperProfile).Assembly });
});

// Register MVC with controllers from all assemblies
services
    .AddMvc()
    .AddApplicationPart(typeof(ASafariM.Presentation.Controllers.MarkdownFilesController).Assembly)
    .AddControllersAsServices();

// Register controllers and API explorer
services.AddControllers();
services.AddEndpointsApiExplorer();

services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            // Add your token validation parameters here
        };
    });

services.AddSwaggerGen();
services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        }
    );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASafariM API V1");
        c.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();
app.UseRouting();

// Use CORS before auth
app.UseCors("AllowFrontend");

// Add static files middleware
app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

// Ensure the inline middleware is correctly implemented
app.Use(
    async (context, next) =>
    {
        Console.WriteLine($"{context.Request.Method} → {context.Request.Path}");
        await next.Invoke();
    }
);

// Map controllers after all middleware
app.MapControllers();

app.Run();
