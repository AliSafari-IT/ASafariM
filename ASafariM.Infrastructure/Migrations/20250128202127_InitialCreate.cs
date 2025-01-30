using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AccessibilityPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EnableHighContrastMode = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EnableScreenReaderSupport = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TextScalingFactor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessibilityPreferences", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsoCode = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsoCode3 = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NativeName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Code = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Symbol = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DecimalPlaces = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DateFormats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Format = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Example = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateFormats", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FileFormats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Extension = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MimeType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SupportsEditing = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    SupportsAnnotations = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MaxSizeInMB = table.Column<int>(type: "int", nullable: false),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileFormats", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LanguagePreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Language = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePreferences", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NotificationPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ReceiveEmailNotifications = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ReceiveSmsNotifications = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsSubscribedToNewsletter = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotificationFrequencyInHours = table.Column<int>(type: "int", nullable: false),
                    AllowMarketingEmails = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationPreferences", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PaginationSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ItemsPerPage = table.Column<int>(type: "int", nullable: false),
                    ShowPageNumbers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ShowFirstLastButtons = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    VisiblePageRange = table.Column<int>(type: "int", nullable: false),
                    EnableInfiniteScroll = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ShowItemsCount = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ShowPageSizeSelector = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PageSizeOptions = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaginationSettings", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PrivacyPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsProfilePublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AllowSearchByEmail = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EnableTwoFactorAuthentication = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AllowDataSharing = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivacyPreferences", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TimeZones",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StandardName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UtcOffset = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsesDaylightSaving = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DstOffset = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DeletedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    FailedLoginAttempts = table.Column<int>(type: "int", nullable: false),
                    IsLockedOut = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Remark = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PenName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Website = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Biography = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ThemePreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsDarkTheme = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FontSize = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LanguageId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AccentColor = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThemePreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThemePreferences_LanguagePreferences_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "LanguagePreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MiscellaneousPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FileFormatId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PaginationSettingsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    EnableAutoSave = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EnableRealTimeUpdates = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DefaultDashboardView = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShowActivityTimeline = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiscellaneousPreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MiscellaneousPreferences_FileFormats_FileFormatId",
                        column: x => x.FileFormatId,
                        principalTable: "FileFormats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MiscellaneousPreferences_PaginationSettings_PaginationSettin~",
                        column: x => x.PaginationSettingsId,
                        principalTable: "PaginationSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GeographicalPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CountryId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CurrencyId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TimeZoneId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DateFormatId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeographicalPreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeographicalPreferences_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeographicalPreferences_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeographicalPreferences_DateFormats_DateFormatId",
                        column: x => x.DateFormatId,
                        principalTable: "DateFormats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeographicalPreferences_TimeZones_TimeZoneId",
                        column: x => x.TimeZoneId,
                        principalTable: "TimeZones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Preferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThemeId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    GeographyId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    NotificationId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    LanguageId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PrivacyId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    AccessibilityId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    MiscellaneousId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preferences_AccessibilityPreferences_AccessibilityId",
                        column: x => x.AccessibilityId,
                        principalTable: "AccessibilityPreferences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Preferences_GeographicalPreferences_GeographyId",
                        column: x => x.GeographyId,
                        principalTable: "GeographicalPreferences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Preferences_LanguagePreferences_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "LanguagePreferences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Preferences_MiscellaneousPreferences_MiscellaneousId",
                        column: x => x.MiscellaneousId,
                        principalTable: "MiscellaneousPreferences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Preferences_NotificationPreferences_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "NotificationPreferences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Preferences_PrivacyPreferences_PrivacyId",
                        column: x => x.PrivacyId,
                        principalTable: "PrivacyPreferences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Preferences_ThemePreferences_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "ThemePreferences",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserPreferences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PreferenceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPreferences_Preferences_PreferenceId",
                        column: x => x.PreferenceId,
                        principalTable: "Preferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MarkdownFileHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MarkdownFileId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ContentSnapshot = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChangedByUserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ChangedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkdownFileHistories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MarkdownFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Visibility = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AuthorName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdatedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    ParentMdFileId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkdownFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarkdownFiles_MarkdownFiles_ParentMdFileId",
                        column: x => x.ParentMdFileId,
                        principalTable: "MarkdownFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_MarkdownFiles_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MarkdownFileUsers",
                columns: table => new
                {
                    MarkdownFileId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DateCollaborated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CollaborationStopDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CollaborationRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkdownFileUsers", x => new { x.MarkdownFileId, x.UserId });
                    table.ForeignKey(
                        name: "FK_MarkdownFileUsers_MarkdownFiles_MarkdownFileId",
                        column: x => x.MarkdownFileId,
                        principalTable: "MarkdownFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarkdownFileUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Visibility = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    OwnerId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Budget = table.Column<double>(type: "double", nullable: true),
                    ActualBudget = table.Column<double>(type: "double", nullable: true),
                    RemainingBudget = table.Column<double>(type: "double", nullable: true),
                    IsCancelled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsCancelledby = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsCancelledAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsCompletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsCompletedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsPaused = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPausedTo = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsExtended = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsExtendedTo = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    MarkdownFileId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_MarkdownFiles_MarkdownFileId",
                        column: x => x.MarkdownFileId,
                        principalTable: "MarkdownFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projects_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProgressHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProgressPercentage = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Notes = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PlannedBudget = table.Column<double>(type: "double", nullable: true),
                    ActualCost = table.Column<double>(type: "double", nullable: true),
                    BudgetVariance = table.Column<double>(type: "double", nullable: true),
                    PlannedStartDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ActualStartDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PlannedEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ActualEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    TimeVarianceInDays = table.Column<int>(type: "int", nullable: true),
                    TotalMilestones = table.Column<int>(type: "int", nullable: false),
                    CompletedMilestones = table.Column<int>(type: "int", nullable: false),
                    CurrentStatus = table.Column<int>(type: "int", nullable: false),
                    StatusReason = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RiskLevel = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RiskDescription = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MitigationPlan = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UpdatedBy = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressHistories_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProjectMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ProjectMemberType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectMembers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectMembers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b7856de-235e-4669-b343-5ddfbc0eeeef"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5051), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("3321a811-4ef8-4e01-a3f1-76f327a8bdc5"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5036), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("55e7dd8f-0b49-442f-80a2-1c34c05e6b9c"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5045), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("89fc43c9-0ff6-45d9-b523-943d0f286b1e"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5038), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("8b880caf-9bd4-4b1e-b0ff-185b67795588"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5043), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("8e54a7ed-fc5d-45e1-b2da-dac3dfb3e12e"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5047), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("d060a2c4-18df-4c2a-b12f-b9472d993f42"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5053), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("f48ec768-9bf2-445a-bbc7-bcf424868923"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5041), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("f659063e-1620-4e90-98f0-fa20beb2528c"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5033), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("fb24e2cf-4940-4c6e-a7fb-ebd23ff22700"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5055), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2e41d2de-2495-496f-bde1-f82aaaa0d8ce"), "EUR", new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4913), 2, true, "Euro", "€", null },
                    { new Guid("65c70f44-0fab-442c-b4c3-3a8fccdeca3f"), "USD", new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4915), 2, true, "US Dollar", "$", null },
                    { new Guid("7672ca09-d81c-4db7-b154-8c48ce58e1ce"), "GBP", new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4918), 2, true, "British Pound", "£", null },
                    { new Guid("c4caabe2-ee97-4b09-aafa-7955132648a6"), "CHF", new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4919), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("025b7e8d-4b32-4811-b318-89477e0f1fd5"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4885), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("532ead27-9bf3-4dbe-9b7b-2e3435c205d0"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4887), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("94e9295e-07bb-4c07-a336-5cb76237e7ad"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4880), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("b5a9b039-b530-4586-852a-f99ec742ddd2"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4883), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16d61393-81e2-4e46-a1cd-97a56a1219b5"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4813), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("3c30fd5e-e7ef-41a3-af62-9effb3883f94"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4820), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("46566d1f-826e-4185-8f2a-a40805b574ba"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4822), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("666216ee-9658-4db7-9898-b2cbf06d724c"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4811), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("a42b361d-4307-4146-ad70-cd17e72f4276"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4818), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("d0d5232d-5878-48bb-9186-fc3d345c5fe9"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4805), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("6e2d9e60-629e-42c2-8615-7c3fd61103d7"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4855), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1fb4eeca-83cf-40d3-9854-98f0e0fa7bc6"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("6b900762-bb55-4618-b4e4-564138f4fc0b"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("6e17060d-a475-462b-8b0d-d3095bd3abba"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("76f273e9-5f18-4bb7-ba0d-1a0374cfb08e"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("b29b4f61-e7fa-4125-b368-cc636e021cc4"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("e9cf88cf-3033-41c0-950e-d7cfbb279910"), "Admin role has full administrative privileges, except for application management.", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("2ca7d9a7-3b31-42e5-ad2d-c62b7d5ba7d7"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4947), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("56438c14-004a-4008-90df-6ac91093a4e0"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4999), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("688f3344-afdc-4680-b64c-57e9cbc467ac"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5004), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("af8ced53-6ac5-45ff-aaa4-eb5cd6277a2f"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4952), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("eaa5d070-1a0e-46bc-8005-d400444feb36"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4950), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_IsoCode",
                table: "Countries",
                column: "IsoCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_IsoCode3",
                table: "Countries",
                column: "IsoCode3",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_Code",
                table: "Currencies",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DateFormats_Format",
                table: "DateFormats",
                column: "Format",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileFormats_Extension",
                table: "FileFormats",
                column: "Extension",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileFormats_MimeType",
                table: "FileFormats",
                column: "MimeType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GeographicalPreferences_CountryId",
                table: "GeographicalPreferences",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_GeographicalPreferences_CurrencyId",
                table: "GeographicalPreferences",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_GeographicalPreferences_DateFormatId",
                table: "GeographicalPreferences",
                column: "DateFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_GeographicalPreferences_TimeZoneId",
                table: "GeographicalPreferences",
                column: "TimeZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFileHistories_MarkdownFileId",
                table: "MarkdownFileHistories",
                column: "MarkdownFileId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFiles_CreatedBy",
                table: "MarkdownFiles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFiles_ParentMdFileId",
                table: "MarkdownFiles",
                column: "ParentMdFileId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFiles_ProjectId",
                table: "MarkdownFiles",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownFileUsers_UserId",
                table: "MarkdownFileUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MiscellaneousPreferences_FileFormatId",
                table: "MiscellaneousPreferences",
                column: "FileFormatId");

            migrationBuilder.CreateIndex(
                name: "IX_MiscellaneousPreferences_PaginationSettingsId",
                table: "MiscellaneousPreferences",
                column: "PaginationSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_AccessibilityId",
                table: "Preferences",
                column: "AccessibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_GeographyId",
                table: "Preferences",
                column: "GeographyId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_LanguageId",
                table: "Preferences",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_MiscellaneousId",
                table: "Preferences",
                column: "MiscellaneousId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_NotificationId",
                table: "Preferences",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_PrivacyId",
                table: "Preferences",
                column: "PrivacyId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_ThemeId",
                table: "Preferences",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressHistories_ProjectId",
                table: "ProgressHistories",
                column: "ProjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_ProjectId",
                table: "ProjectMembers",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMembers_UserId",
                table: "ProjectMembers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_MarkdownFileId",
                table: "Projects",
                column: "MarkdownFileId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ThemePreferences_LanguageId",
                table: "ThemePreferences",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeZones_StandardName",
                table: "TimeZones",
                column: "StandardName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_PreferenceId",
                table: "UserPreferences",
                column: "PreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_UserId_PreferenceId",
                table: "UserPreferences",
                columns: new[] { "UserId", "PreferenceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownFileHistories_MarkdownFiles_MarkdownFileId",
                table: "MarkdownFileHistories",
                column: "MarkdownFileId",
                principalTable: "MarkdownFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownFiles_Projects_ProjectId",
                table: "MarkdownFiles",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_MarkdownFiles_MarkdownFileId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "MarkdownFileHistories");

            migrationBuilder.DropTable(
                name: "MarkdownFileUsers");

            migrationBuilder.DropTable(
                name: "ProgressHistories");

            migrationBuilder.DropTable(
                name: "ProjectMembers");

            migrationBuilder.DropTable(
                name: "UserPreferences");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Preferences");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "AccessibilityPreferences");

            migrationBuilder.DropTable(
                name: "GeographicalPreferences");

            migrationBuilder.DropTable(
                name: "MiscellaneousPreferences");

            migrationBuilder.DropTable(
                name: "NotificationPreferences");

            migrationBuilder.DropTable(
                name: "PrivacyPreferences");

            migrationBuilder.DropTable(
                name: "ThemePreferences");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "DateFormats");

            migrationBuilder.DropTable(
                name: "TimeZones");

            migrationBuilder.DropTable(
                name: "FileFormats");

            migrationBuilder.DropTable(
                name: "PaginationSettings");

            migrationBuilder.DropTable(
                name: "LanguagePreferences");

            migrationBuilder.DropTable(
                name: "MarkdownFiles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
