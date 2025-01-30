using ASafariM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using TimeZone = ASafariM.Domain.Entities.TimeZone;

namespace ASafariM.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    // User-related sets
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    // Preference sets
    public DbSet<Preference> Preferences { get; set; }
    public DbSet<UserPreference> UserPreferences { get; set; }
    public DbSet<AccessibilityPreference> AccessibilityPreferences { get; set; }
    public DbSet<GeographicalPreference> GeographicalPreferences { get; set; }
    public DbSet<NotificationPreference> NotificationPreferences { get; set; }
    public DbSet<PrivacyPreference> PrivacyPreferences { get; set; }
    public DbSet<MiscellaneousPreference> MiscellaneousPreferences { get; set; }
    public DbSet<ThemePreference> ThemePreferences { get; set; }
    public DbSet<LanguagePreference> LanguagePreferences { get; set; }

    // Supporting preference sets
    public DbSet<Currency> Currencies { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<TimeZone> TimeZones { get; set; }
    public DbSet<DateFormat> DateFormats { get; set; }
    public DbSet<FileFormat> FileFormats { get; set; }
    public DbSet<PaginationSettings> PaginationSettings { get; set; }

    // Project-related sets
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectMember> ProjectMembers { get; set; }
    public DbSet<ProgressHistory> ProgressHistories { get; set; }

    // Markdown-related sets
    public DbSet<MarkdownFile> MarkdownFiles { get; set; }
    public DbSet<MarkdownFileUser> MarkdownFileUsers { get; set; }
    public DbSet<MarkdownFileHistory> MarkdownFileHistories { get; set; }

    // Blog-related sets
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<SitemapItem> SitemapItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure SitemapItem entity
        modelBuilder.Entity<SitemapItem>(entity =>
        {
            entity.HasKey(s => s.Id);

            // Configure self-referencing relationship
            entity
                .HasOne(s => s.Parent)
                .WithMany(s => s.Children)
                .HasForeignKey(s => s.ParentItemId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure many-to-many relationship with Topics
            entity.HasMany(s => s.Topics).WithMany();
        });

        // Configure PostTag entity
        modelBuilder.Entity<PostTag>(entity =>
        {
            entity.HasKey(pt => new { pt.PostId, pt.TagId });

            entity.HasOne(pt => pt.Post).WithMany(p => p.PostTags).HasForeignKey(pt => pt.PostId);

            entity.HasOne(pt => pt.Tag).WithMany(t => t.PostTags).HasForeignKey(pt => pt.TagId);
        });

        // Configure User entity
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.Property(u => u.FirstName).HasMaxLength(50).IsRequired();
            entity.Property(u => u.LastName).HasMaxLength(50).IsRequired();
            entity.Property(u => u.Email).HasMaxLength(100).IsRequired();
            entity.Property(u => u.PasswordHash).IsRequired();
            entity.Property(u => u.LastLogin).HasColumnType("datetime(6)").IsRequired(false);
            entity.Property(u => u.NormalizedUserName).HasMaxLength(50);
            entity.Property(u => u.SecurityStamp).IsRequired();
            entity.Property(u => u.ConcurrencyStamp).IsRequired();

            // One-to-Many: User → Project (as Owner)
            entity
                .HasMany(u => u.OwnedProjects)
                .WithOne(p => p.Owner)
                .HasForeignKey(p => p.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            // One-to-Many: User → MarkdownFile (as Author)
            entity
                .HasMany(u => u.AuthoredMarkdownFiles)
                .WithOne()
                .HasForeignKey(mf => mf.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            // Many-to-Many: User ↔ MarkdownFile (as Collaborator)
            entity
                .HasMany(u => u.CollaboratedMarkdownFiles)
                .WithMany(mf => mf.Collaborators)
                .UsingEntity<MarkdownFileUser>();
        });

        // Configure Role entity
        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(r => r.Id);
            entity.Property(r => r.Name).HasMaxLength(50).IsRequired();
            entity.Property(r => r.Description).HasMaxLength(200);
        });

        // Configure UserRole entity (Many-to-Many: User ↔ Role)
        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(ur => new { ur.UserId, ur.RoleId });

            entity
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure Preference entity
        modelBuilder.Entity<Preference>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Name).HasMaxLength(100).IsRequired();
            entity.Property(p => p.Description).HasMaxLength(500);

            // Configure one-to-one relationships with preference types
            entity.HasOne(p => p.Theme);
            entity.HasOne(p => p.Geography);
            entity.HasOne(p => p.Notification);
            entity.HasOne(p => p.Language);
            entity.HasOne(p => p.Privacy);
            entity.HasOne(p => p.Accessibility);
            entity.HasOne(p => p.Miscellaneous);
        });

        // Configure UserPreference entity (junction table)
        modelBuilder.Entity<UserPreference>(entity =>
        {
            entity.HasKey(up => up.Id);

            entity
                .HasOne(up => up.User)
                .WithMany(u => u.Preferences)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(up => up.Preference)
                .WithMany(p => p.UserPreferences)
                .HasForeignKey(up => up.PreferenceId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.Property(up => up.CreatedAt).HasColumnType("datetime(6)").IsRequired();
            entity.Property(up => up.UpdatedAt).HasColumnType("datetime(6)").IsRequired(false);
            entity.HasIndex(up => new { up.UserId, up.PreferenceId }).IsUnique();
        });

        // Configure Project entity
        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Name).HasMaxLength(120).IsRequired();
            entity.Property(p => p.Description).HasMaxLength(500);

            entity
                .HasMany(p => p.ProjectMembers)
                .WithOne(pm => pm.Project)
                .HasForeignKey(pm => pm.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasMany(p => p.MarkdownFiles)
                .WithOne(mf => mf.Project)
                .HasForeignKey(mf => mf.ProjectId)
                .OnDelete(DeleteBehavior.SetNull);

            entity
                .HasOne(p => p.Progress)
                .WithOne(ph => ph.Project)
                .HasForeignKey<ProgressHistory>(ph => ph.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure ProjectMember entity
        modelBuilder.Entity<ProjectMember>(entity =>
        {
            entity.HasKey(pm => pm.Id);

            entity
                .HasOne(pm => pm.User)
                .WithMany(u => u.ProjectMemberships)
                .HasForeignKey(pm => pm.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure MarkdownFile entity
        modelBuilder.Entity<MarkdownFile>(entity =>
        {
            entity.HasKey(mf => mf.Id);
            entity.Property(mf => mf.Title).HasMaxLength(255).IsRequired();
            entity.Property(mf => mf.Content).IsRequired();
            entity.Property(mf => mf.AuthorName).HasMaxLength(100);

            // Configure self-referencing relationship for parent-child files
            entity
                .HasOne(mf => mf.ParentMdFile)
                .WithMany()
                .HasForeignKey(mf => mf.ParentMdFileId)
                .OnDelete(DeleteBehavior.SetNull);

            // Configure relationship with MarkdownFileHistory
            entity
                .HasMany(mf => mf.History)
                .WithOne(mfh => mfh.MarkdownFile)
                .HasForeignKey(mfh => mfh.MarkdownFileId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure MarkdownFileHistory entity
        modelBuilder.Entity<MarkdownFileHistory>(entity =>
        {
            entity.HasKey(mfh => mfh.Id);
            entity.Property(mfh => mfh.ContentSnapshot).IsRequired();
            entity.Property(mfh => mfh.ChangedAt).HasColumnType("datetime(6)").IsRequired();
        });

        // Configure MarkdownFileUser entity
        modelBuilder.Entity<MarkdownFileUser>(entity =>
        {
            entity.HasKey(mfu => new { mfu.MarkdownFileId, mfu.UserId });

            entity
                .HasOne(mfu => mfu.User)
                .WithMany(u => u.MarkdownFileUsers)
                .HasForeignKey(mfu => mfu.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            entity
                .HasOne(mfu => mfu.MarkdownFile)
                .WithMany(mf => mf.MarkdownFileUsers)
                .HasForeignKey(mfu => mfu.MarkdownFileId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure Country entity
        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.IsoCode).HasMaxLength(2).IsRequired();
            entity.Property(c => c.IsoCode3).HasMaxLength(3).IsRequired();
            entity.Property(c => c.Name).HasMaxLength(100).IsRequired();
            entity.Property(c => c.NativeName).HasMaxLength(100).IsRequired();
            entity.Property(c => c.PhoneCode).HasMaxLength(10).IsRequired();
            entity.HasIndex(c => c.IsoCode).IsUnique();
            entity.HasIndex(c => c.IsoCode3).IsUnique();
        });

        // Configure TimeZone entity
        modelBuilder.Entity<TimeZone>(entity =>
        {
            entity.HasKey(tz => tz.Id);
            entity.Property(tz => tz.Name).HasMaxLength(50).IsRequired();
            entity.Property(tz => tz.StandardName).HasMaxLength(50).IsRequired();
            entity.Property(tz => tz.UtcOffset).HasMaxLength(6).IsRequired();
            entity.Property(tz => tz.DstOffset).HasMaxLength(6);

            entity.HasIndex(tz => tz.StandardName).IsUnique();
        });

        // Configure DateFormat entity
        modelBuilder.Entity<DateFormat>(entity =>
        {
            entity.HasKey(df => df.Id);
            entity.Property(df => df.Format).HasMaxLength(20).IsRequired();
            entity.Property(df => df.DisplayName).HasMaxLength(50).IsRequired();
            entity.Property(df => df.Example).HasMaxLength(20).IsRequired();

            entity.HasIndex(df => df.Format).IsUnique();
        });

        // Configure Currency entity
        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Code).HasMaxLength(3).IsRequired();
            entity.Property(c => c.Name).HasMaxLength(100).IsRequired();
            entity.Property(c => c.Symbol).HasMaxLength(5).IsRequired();

            entity.HasIndex(c => c.Code).IsUnique();
        });

        // Configure FileFormat entity
        modelBuilder.Entity<FileFormat>(entity =>
        {
            entity.HasKey(ff => ff.Id);
            entity.Property(ff => ff.Extension).HasMaxLength(10).IsRequired();
            entity.Property(ff => ff.Name).HasMaxLength(50).IsRequired();
            entity.Property(ff => ff.MimeType).HasMaxLength(100).IsRequired();
            entity.Property(ff => ff.Description).HasMaxLength(255);

            entity.HasIndex(ff => ff.Extension).IsUnique();
            entity.HasIndex(ff => ff.MimeType).IsUnique();
        });

        // Configure PaginationSettings entity
        modelBuilder.Entity<PaginationSettings>(entity =>
        {
            entity.HasKey(ps => ps.Id);
            entity.Property(ps => ps.ItemsPerPage).IsRequired();
            entity.Property(ps => ps.PageSizeOptions).HasMaxLength(100).IsRequired();
        });

        // Configure GeographicalPreference entity
        modelBuilder.Entity<GeographicalPreference>(entity =>
        {
            entity.HasKey(gp => gp.Id);

            entity
                .HasOne(gp => gp.Country)
                .WithMany(c => c.GeographicalPreferences)
                .HasForeignKey(gp => gp.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(gp => gp.Currency)
                .WithMany()
                .HasForeignKey(gp => gp.CurrencyId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(gp => gp.TimeZone)
                .WithMany(tz => tz.GeographicalPreferences)
                .HasForeignKey(gp => gp.TimeZoneId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(gp => gp.DateFormat)
                .WithMany(df => df.GeographicalPreferences)
                .HasForeignKey(gp => gp.DateFormatId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Configure MiscellaneousPreference entity
        modelBuilder.Entity<MiscellaneousPreference>(entity =>
        {
            entity.HasKey(mp => mp.Id);

            entity
                .HasOne(mp => mp.FileFormat)
                .WithMany(ff => ff.MiscellaneousPreferences)
                .HasForeignKey(mp => mp.FileFormatId)
                .OnDelete(DeleteBehavior.Restrict);

            entity
                .HasOne(mp => mp.PaginationSettings)
                .WithMany(ps => ps.MiscellaneousPreferences)
                .HasForeignKey(mp => mp.PaginationSettingsId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        // Configure other preference entities
        modelBuilder.Entity<AccessibilityPreference>().HasKey(ap => ap.Id);
        modelBuilder.Entity<LanguagePreference>().HasKey(lp => lp.Id);
        modelBuilder.Entity<NotificationPreference>().HasKey(np => np.Id);
        modelBuilder.Entity<PrivacyPreference>().HasKey(pp => pp.Id);
        modelBuilder.Entity<ThemePreference>().HasKey(tp => tp.Id);

        // Configure ProgressHistory entity
        modelBuilder.Entity<ProgressHistory>(entity =>
        {
            entity.HasKey(ph => ph.Id);
            entity.Property(ph => ph.Description).HasMaxLength(500);
            entity.Property(ph => ph.Notes).HasMaxLength(1000);
            entity.Property(ph => ph.StatusReason).HasMaxLength(500);
            entity.Property(ph => ph.RiskLevel).HasMaxLength(50);
            entity.Property(ph => ph.RiskDescription).HasMaxLength(500);
            entity.Property(ph => ph.MitigationPlan).HasMaxLength(1000);
        });
        modelBuilder
            .Entity<Role>()
            .HasData(
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Admin",
                    Description =
                        "Admin role has full administrative privileges, except for application management.",
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Moderator",
                    Description =
                        "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.",
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "User",
                    Description =
                        "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.",
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Guest",
                    Description =
                        "Guest role is the least privileged role. They can only view public articles.",
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "Editor",
                    Description =
                        "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.",
                },
                new Role
                {
                    Id = Guid.NewGuid(),
                    Name = "SuperAdmin",
                    Description =
                        "Has full control over the application and can manage all aspects.",
                }
            );

        modelBuilder
            .Entity<FileFormat>()
            .HasData(
                new FileFormat
                {
                    Id = Guid.NewGuid(),
                    Name = "Plain Text",
                    Extension = ".txt",
                    MimeType = "text/plain",
                    Description = "Simple text document format",
                },
                new FileFormat
                {
                    Id = Guid.NewGuid(),
                    Name = "TypeScript",
                    Extension = ".ts",
                    MimeType = "application/typescript",
                    Description = "TypeScript source code file",
                },
                new FileFormat
                {
                    Id = Guid.NewGuid(),
                    Name = "TypeScript React",
                    Extension = ".tsx",
                    MimeType = "application/typescript+react",
                    Description = "TypeScript React component file",
                },
                new FileFormat
                {
                    Id = Guid.NewGuid(),
                    Name = "JavaScript",
                    Extension = ".js",
                    MimeType = "application/javascript",
                    Description = "JavaScript source code file",
                },
                new FileFormat
                {
                    Id = Guid.NewGuid(),
                    Name = "JSON",
                    Extension = ".json",
                    MimeType = "application/json",
                    Description = "JavaScript Object Notation data file",
                },
                new FileFormat
                {
                    Id = Guid.NewGuid(),
                    Name = "Markdown",
                    Extension = ".md",
                    MimeType = "text/markdown",
                    Description = "Markdown text format",
                }
            );

        modelBuilder
            .Entity<PaginationSettings>()
            .HasData(
                new PaginationSettings
                {
                    Id = Guid.NewGuid(),
                    ItemsPerPage = 10,
                    PageSizeOptions = "[10,20,50,100]",
                }
            );

        modelBuilder
            .Entity<DateFormat>()
            .HasData(
                new DateFormat
                {
                    Id = Guid.NewGuid(),
                    Format = "dd/MM/yyyy",
                    DisplayName = "Belgian/European Date Format",
                    Example = "31/12/2024",
                },
                new DateFormat
                {
                    Id = Guid.NewGuid(),
                    Format = "dd.MM.yyyy",
                    DisplayName = "Belgian Date Format (Dot)",
                    Example = "31.12.2024",
                },
                new DateFormat
                {
                    Id = Guid.NewGuid(),
                    Format = "MM/dd/yyyy",
                    DisplayName = "US Date Format",
                    Example = "12/31/2024",
                },
                new DateFormat
                {
                    Id = Guid.NewGuid(),
                    Format = "yyyy-MM-dd",
                    DisplayName = "ISO Date Format",
                    Example = "2024-12-31",
                }
            );

        modelBuilder
            .Entity<Currency>()
            .HasData(
                new Currency
                {
                    Id = Guid.NewGuid(),
                    Code = "EUR",
                    Name = "Euro",
                    Symbol = "€",
                },
                new Currency
                {
                    Id = Guid.NewGuid(),
                    Code = "USD",
                    Name = "US Dollar",
                    Symbol = "$",
                },
                new Currency
                {
                    Id = Guid.NewGuid(),
                    Code = "GBP",
                    Name = "British Pound",
                    Symbol = "£",
                },
                new Currency
                {
                    Id = Guid.NewGuid(),
                    Code = "CHF",
                    Name = "Swiss Franc",
                    Symbol = "Fr.",
                }
            );

        modelBuilder
            .Entity<TimeZone>()
            .HasData(
                new TimeZone
                {
                    Id = Guid.NewGuid(),
                    Name = "CET",
                    StandardName = "Central European Time (Belgium)",
                    UtcOffset = "+01:00",
                    DstOffset = "+02:00",
                },
                new TimeZone
                {
                    Id = Guid.NewGuid(),
                    Name = "CEST",
                    StandardName = "Central European Summer Time",
                    UtcOffset = "+02:00",
                    DstOffset = "+02:00",
                },
                new TimeZone
                {
                    Id = Guid.NewGuid(),
                    Name = "UTC",
                    StandardName = "Coordinated Universal Time",
                    UtcOffset = "+00:00",
                },
                new TimeZone
                {
                    Id = Guid.NewGuid(),
                    Name = "WET",
                    StandardName = "Western European Time",
                    UtcOffset = "+00:00",
                    DstOffset = "+01:00",
                },
                new TimeZone
                {
                    Id = Guid.NewGuid(),
                    Name = "EET",
                    StandardName = "Eastern European Time",
                    UtcOffset = "+02:00",
                    DstOffset = "+03:00",
                }
            );

        modelBuilder
            .Entity<Country>()
            .HasData(
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "BE",
                    IsoCode3 = "BEL",
                    Name = "Belgium",
                    NativeName = "België",
                    PhoneCode = "+32",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "FR",
                    IsoCode3 = "FRA",
                    Name = "France",
                    NativeName = "France",
                    PhoneCode = "+33",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "DE",
                    IsoCode3 = "DEU",
                    Name = "Germany",
                    NativeName = "Deutschland",
                    PhoneCode = "+49",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "NL",
                    IsoCode3 = "NLD",
                    Name = "Netherlands",
                    NativeName = "Nederland",
                    PhoneCode = "+31",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "GB",
                    IsoCode3 = "GBR",
                    Name = "United Kingdom",
                    NativeName = "United Kingdom",
                    PhoneCode = "+44",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "IT",
                    IsoCode3 = "ITA",
                    Name = "Italy",
                    NativeName = "Italia",
                    PhoneCode = "+39",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "ES",
                    IsoCode3 = "ESP",
                    Name = "Spain",
                    NativeName = "España",
                    PhoneCode = "+34",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "CH",
                    IsoCode3 = "CHE",
                    Name = "Switzerland",
                    NativeName = "Schweiz",
                    PhoneCode = "+41",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "AT",
                    IsoCode3 = "AUT",
                    Name = "Austria",
                    NativeName = "Österreich",
                    PhoneCode = "+43",
                },
                new Country
                {
                    Id = Guid.NewGuid(),
                    IsoCode = "LU",
                    IsoCode3 = "LUX",
                    Name = "Luxembourg",
                    NativeName = "Luxembourg",
                    PhoneCode = "+352",
                }
            );
    }
}
