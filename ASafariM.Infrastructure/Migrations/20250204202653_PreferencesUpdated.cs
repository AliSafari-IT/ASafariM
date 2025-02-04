using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PreferencesUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("250ec265-ea45-40fe-943d-9e4b07906d32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a97db4a-68b1-4ba0-8301-85e847fb571f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4a6ed093-54e6-48ad-88e1-a165440039a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("563d0668-4202-488c-8656-860211c4f438"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("60f3378c-3552-4333-b1f0-379fec6d65f1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8022066e-dfcb-4d38-a66d-ca82d97e3d63"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("939be5db-8e6f-45c9-b933-b1fc7b74f2d8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a26f32e3-7a36-47f1-bf7f-132ec6d1ad9b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b174e420-b2e3-4be9-9329-34db2a1db916"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b9d1be13-a4d2-4240-9494-255b07a77fcf"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1ac07e2d-83da-41bc-931a-808adc9912d9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("33baac0f-8c4d-47c9-a0d1-9fe295afeeb0"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("6e6342ef-9c76-4e98-8877-d37d184e0110"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d255e337-2db7-4238-b40c-179311d7592f"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("5b26d283-805b-414c-8fbc-24d8e68199a8"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("621b649f-85a4-4ecb-8387-dd9a519134a9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("78831b46-548b-4581-b4a5-e24fc0757a15"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("8abdd52d-9b8c-4364-b202-19a140dbe39d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("21a6b01c-6479-4275-a0ec-e7332704e59c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("35d52f56-8b91-45ef-9d34-1ee2e824d82b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("4906bdda-5f28-40ff-a620-d0eeb373dfcf"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("55b56323-4952-4c5a-ad55-840d6b487e07"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("87c16888-030f-44ed-a5f8-1aa76f0181f9"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f53f6c0a-35b8-402c-be00-5bfd2107c826"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("40bdef81-9230-4cc6-900b-b16a7d8f44fd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1fe46922-c109-4bf2-b000-0921272598a4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8f7127e6-b35f-400f-81e3-3acc7951174f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9f4cb41d-9558-4d9e-a2a6-fa720848aac5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a4863714-4de7-496b-92c1-b965cdb7f171"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ddcf50e9-1f56-41fa-9c08-98c588b797d0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fb09d102-7d1d-4b89-a369-0efb28c36907"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2236583b-17fe-4be6-a352-4c08b452b230"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7606524-61a5-4f7e-83ba-1e161f80c1b3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cfab2ef3-3aaf-42b6-a7f6-b0060da8e5a4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d634ea1d-7bd9-41bc-9878-2dd191a0f11a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("4b888a63-8eb7-4600-8210-962cfa214e02"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("64e76fbe-8524-420d-bafc-3f3db1c3bffd"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9fc93f4e-778a-418f-8dea-096da6e81b43"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c3ec7f8d-d928-48e5-81f8-c30bff3b0ae6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("e81d43c0-605f-4299-8fdf-1ae63ea0383d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("11904e37-4d3b-4516-a1cd-849df20ce6b7"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("21a49242-f262-44f4-b343-2561b24317ea"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("cb73ed73-8488-4d4f-a5c7-063b71d09987"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0de748a4-9c15-4d2f-bda5-7566c31da3c4"));

            migrationBuilder.CreateTable(
                name: "UserAccessibilityPreferences",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AccessibilityPreferenceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccessibilityPreferences", x => new { x.UserId, x.AccessibilityPreferenceId });
                    table.ForeignKey(
                        name: "FK_UserAccessibilityPreferences_AccessibilityPreferences_Access~",
                        column: x => x.AccessibilityPreferenceId,
                        principalTable: "AccessibilityPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAccessibilityPreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserGeographicalPreferences",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GeographicalPreferenceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGeographicalPreferences", x => new { x.UserId, x.GeographicalPreferenceId });
                    table.ForeignKey(
                        name: "FK_UserGeographicalPreferences_GeographicalPreferences_Geograph~",
                        column: x => x.GeographicalPreferenceId,
                        principalTable: "GeographicalPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGeographicalPreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserLanguagePreferences",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LanguagePreferenceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLanguagePreferences", x => new { x.UserId, x.LanguagePreferenceId });
                    table.ForeignKey(
                        name: "FK_UserLanguagePreferences_LanguagePreferences_LanguagePreferen~",
                        column: x => x.LanguagePreferenceId,
                        principalTable: "LanguagePreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLanguagePreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserMiscellaneousPreferences",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MiscellaneousPreferenceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMiscellaneousPreferences", x => new { x.UserId, x.MiscellaneousPreferenceId });
                    table.ForeignKey(
                        name: "FK_UserMiscellaneousPreferences_MiscellaneousPreferences_Miscel~",
                        column: x => x.MiscellaneousPreferenceId,
                        principalTable: "MiscellaneousPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMiscellaneousPreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserNotificationPreferences",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    NotificationPreferenceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotificationPreferences", x => new { x.UserId, x.NotificationPreferenceId });
                    table.ForeignKey(
                        name: "FK_UserNotificationPreferences_NotificationPreferences_Notifica~",
                        column: x => x.NotificationPreferenceId,
                        principalTable: "NotificationPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNotificationPreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserPrivacyPreferences",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PrivacyPreferenceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPrivacyPreferences", x => new { x.UserId, x.PrivacyPreferenceId });
                    table.ForeignKey(
                        name: "FK_UserPrivacyPreferences_PrivacyPreferences_PrivacyPreferenceId",
                        column: x => x.PrivacyPreferenceId,
                        principalTable: "PrivacyPreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPrivacyPreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserThemePreferences",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ThemePreferenceId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserThemePreferences", x => new { x.UserId, x.ThemePreferenceId });
                    table.ForeignKey(
                        name: "FK_UserThemePreferences_ThemePreferences_ThemePreferenceId",
                        column: x => x.ThemePreferenceId,
                        principalTable: "ThemePreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserThemePreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0986659e-5272-43f6-b065-d145b336c131"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7747), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("13d95545-7493-436b-8e3c-3aca0397eedb"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7701), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("154a04f0-4e8c-4ea3-8ff2-c299f1543ed3"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7737), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("3c7e4df8-03cb-4140-ac95-b6ad623beee9"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7725), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("3cb32126-5921-4130-86b7-116339eb3513"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7740), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("ad0c724e-34bc-4920-a50e-83eef7ab8e36"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7734), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("bf77a5c9-4457-4403-aa59-d3e162e6ea27"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7728), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("c2515b89-c7a2-481e-971e-18f967251047"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7722), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("caa02f46-563e-40df-a4cd-b9f874d7f094"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7731), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("f41cd862-4858-4343-b6f3-531391fa6083"), "Brussels", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7718), true, "FR", "FRA", "France", "France", "+33", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06493f41-3e6b-40bd-b2a0-1e42285d2567"), "USD", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7384), 2, true, "US Dollar", "$", null },
                    { new Guid("5178cdd9-584a-42c3-995a-c5b42da01b6a"), "EUR", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7379), 2, true, "Euro", "€", null },
                    { new Guid("91c06ef3-c591-4b35-a2fd-e53fc82909c5"), "GBP", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7392), 2, true, "British Pound", "£", null },
                    { new Guid("c9ebe11e-902d-4f2d-bcb2-7618b47e0e68"), "CHF", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7395), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("50a77dd6-b960-40ac-9276-b3b5eb0a4c4a"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7291), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("52c0e4ab-19ec-4322-9c1a-ff97e2a559cf"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7309), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("d83df617-f96e-4446-bfca-1578676b5be8"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7300), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("da30763b-e590-47ca-b3e9-9b634def2744"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7304), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01a22533-5dba-4951-9f8c-91e00f0d4e8e"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7062), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("144c5b72-d8da-4115-8f0a-127c8202bb41"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7077), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("1ab93aa4-a856-4637-8fe1-ba4e1e875fbd"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7071), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("3285d7a6-1187-47d6-bcf2-228be2d4c667"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7080), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("52a448fc-0802-4dc4-aea7-04e53ad75036"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7089), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("d0ed5af0-884a-40e7-b944-68926d04d35f"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7074), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("7a95cff5-bbd6-4ba2-b127-321e73fa8b4a"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7199), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("138d3f7f-3123-4a0f-ac01-38035c32788e"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6900), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("515dbcf5-618d-44b4-b198-7c6dfc5a0988"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6944), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("574be12d-46d7-4ecc-9583-cf24f5de9563"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6908), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("68ee5bbf-c0de-471f-afc5-ba81896c89de"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6911), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("6ac67531-fadb-45e9-9e08-2bac78fbe1b9"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6936), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("e8dbbc71-f715-47db-b302-253aaec34666"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6939), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "PostId", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3d19a8aa-1281-4054-a0ce-fbaa4cdfc874"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", null, "test-tag-slug-3", null },
                    { new Guid("81029a4e-c577-42e7-a9cb-cf724cbf56d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", null, "test-tag-slug", null },
                    { new Guid("d312e067-e0b4-4cba-9a55-9285c1cc8f80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", null, "test-tag-slug-2", null },
                    { new Guid("effc9705-8d85-476f-bf71-40e5945366ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", null, "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("40a64179-9870-4241-82b0-91b8e899d772"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7504), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("666958d8-bd05-4e0c-8d10-a0c665edbd25"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7495), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("eb6d7384-32ce-4a22-b2a7-a25f3d1642c6"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7500), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("ec083be0-244f-42d5-9707-df9e81f3fd67"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7614), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("f15d99ba-d036-4e6e-b277-b3304f14fccb"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7618), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a67620c7-edd6-4055-96a5-d6cc2e99a805"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7943), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("e79f71d4-3ef5-4cce-9d30-d35a6126ba92"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7935), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("f0d3ef35-a214-4d3a-a20d-312230d8c51a"), new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(7948), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("6c872040-a7f6-4b10-88b0-0f0828e0a215"), null, "ali@asafarim.com", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6083), new Guid("be157769-b63b-463c-8927-b1ff619107a8"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali", true, true, false, false, new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6072), "Safari", null, "", "ali@asafarim.com", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, null, false, null, null, "https://example.com/profile.jpg", null, "ali@asafarim.com", new DateTime(2025, 2, 4, 20, 26, 52, 195, DateTimeKind.Utc).AddTicks(6085), new Guid("92da9fdc-a902-491b-904e-ae49cd75ca10"), null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessibilityPreferences_AccessibilityPreferenceId",
                table: "UserAccessibilityPreferences",
                column: "AccessibilityPreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGeographicalPreferences_GeographicalPreferenceId",
                table: "UserGeographicalPreferences",
                column: "GeographicalPreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguagePreferences_LanguagePreferenceId",
                table: "UserLanguagePreferences",
                column: "LanguagePreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMiscellaneousPreferences_MiscellaneousPreferenceId",
                table: "UserMiscellaneousPreferences",
                column: "MiscellaneousPreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotificationPreferences_NotificationPreferenceId",
                table: "UserNotificationPreferences",
                column: "NotificationPreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPrivacyPreferences_PrivacyPreferenceId",
                table: "UserPrivacyPreferences",
                column: "PrivacyPreferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserThemePreferences_ThemePreferenceId",
                table: "UserThemePreferences",
                column: "ThemePreferenceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccessibilityPreferences");

            migrationBuilder.DropTable(
                name: "UserGeographicalPreferences");

            migrationBuilder.DropTable(
                name: "UserLanguagePreferences");

            migrationBuilder.DropTable(
                name: "UserMiscellaneousPreferences");

            migrationBuilder.DropTable(
                name: "UserNotificationPreferences");

            migrationBuilder.DropTable(
                name: "UserPrivacyPreferences");

            migrationBuilder.DropTable(
                name: "UserThemePreferences");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0986659e-5272-43f6-b065-d145b336c131"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13d95545-7493-436b-8e3c-3aca0397eedb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("154a04f0-4e8c-4ea3-8ff2-c299f1543ed3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c7e4df8-03cb-4140-ac95-b6ad623beee9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3cb32126-5921-4130-86b7-116339eb3513"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ad0c724e-34bc-4920-a50e-83eef7ab8e36"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf77a5c9-4457-4403-aa59-d3e162e6ea27"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c2515b89-c7a2-481e-971e-18f967251047"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("caa02f46-563e-40df-a4cd-b9f874d7f094"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f41cd862-4858-4343-b6f3-531391fa6083"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("06493f41-3e6b-40bd-b2a0-1e42285d2567"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5178cdd9-584a-42c3-995a-c5b42da01b6a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("91c06ef3-c591-4b35-a2fd-e53fc82909c5"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c9ebe11e-902d-4f2d-bcb2-7618b47e0e68"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("50a77dd6-b960-40ac-9276-b3b5eb0a4c4a"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("52c0e4ab-19ec-4322-9c1a-ff97e2a559cf"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d83df617-f96e-4446-bfca-1578676b5be8"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("da30763b-e590-47ca-b3e9-9b634def2744"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("01a22533-5dba-4951-9f8c-91e00f0d4e8e"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("144c5b72-d8da-4115-8f0a-127c8202bb41"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("1ab93aa4-a856-4637-8fe1-ba4e1e875fbd"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3285d7a6-1187-47d6-bcf2-228be2d4c667"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("52a448fc-0802-4dc4-aea7-04e53ad75036"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d0ed5af0-884a-40e7-b944-68926d04d35f"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("7a95cff5-bbd6-4ba2-b127-321e73fa8b4a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("138d3f7f-3123-4a0f-ac01-38035c32788e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("515dbcf5-618d-44b4-b198-7c6dfc5a0988"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("574be12d-46d7-4ecc-9583-cf24f5de9563"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68ee5bbf-c0de-471f-afc5-ba81896c89de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6ac67531-fadb-45e9-9e08-2bac78fbe1b9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e8dbbc71-f715-47db-b302-253aaec34666"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3d19a8aa-1281-4054-a0ce-fbaa4cdfc874"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("81029a4e-c577-42e7-a9cb-cf724cbf56d6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d312e067-e0b4-4cba-9a55-9285c1cc8f80"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("effc9705-8d85-476f-bf71-40e5945366ac"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("40a64179-9870-4241-82b0-91b8e899d772"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("666958d8-bd05-4e0c-8d10-a0c665edbd25"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("eb6d7384-32ce-4a22-b2a7-a25f3d1642c6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ec083be0-244f-42d5-9707-df9e81f3fd67"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f15d99ba-d036-4e6e-b277-b3304f14fccb"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a67620c7-edd6-4055-96a5-d6cc2e99a805"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e79f71d4-3ef5-4cce-9d30-d35a6126ba92"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f0d3ef35-a214-4d3a-a20d-312230d8c51a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c872040-a7f6-4b10-88b0-0f0828e0a215"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("250ec265-ea45-40fe-943d-9e4b07906d32"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7472), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("3a97db4a-68b1-4ba0-8301-85e847fb571f"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7453), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("4a6ed093-54e6-48ad-88e1-a165440039a6"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7479), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("563d0668-4202-488c-8656-860211c4f438"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7469), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("60f3378c-3552-4333-b1f0-379fec6d65f1"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7465), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("8022066e-dfcb-4d38-a66d-ca82d97e3d63"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7467), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("939be5db-8e6f-45c9-b933-b1fc7b74f2d8"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7460), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("a26f32e3-7a36-47f1-bf7f-132ec6d1ad9b"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7477), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("b174e420-b2e3-4be9-9329-34db2a1db916"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7458), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("b9d1be13-a4d2-4240-9494-255b07a77fcf"), "Brussels", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7463), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1ac07e2d-83da-41bc-931a-808adc9912d9"), "GBP", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7374), 2, true, "British Pound", "£", null },
                    { new Guid("33baac0f-8c4d-47c9-a0d1-9fe295afeeb0"), "USD", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7371), 2, true, "US Dollar", "$", null },
                    { new Guid("6e6342ef-9c76-4e98-8877-d37d184e0110"), "CHF", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7377), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("d255e337-2db7-4238-b40c-179311d7592f"), "EUR", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7365), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5b26d283-805b-414c-8fbc-24d8e68199a8"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7323), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("621b649f-85a4-4ecb-8387-dd9a519134a9"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7264), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("78831b46-548b-4581-b4a5-e24fc0757a15"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7270), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("8abdd52d-9b8c-4364-b202-19a140dbe39d"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7267), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("21a6b01c-6479-4275-a0ec-e7332704e59c"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7192), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("35d52f56-8b91-45ef-9d34-1ee2e824d82b"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7189), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("4906bdda-5f28-40ff-a620-d0eeb373dfcf"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7199), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("55b56323-4952-4c5a-ad55-840d6b487e07"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7194), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("87c16888-030f-44ed-a5f8-1aa76f0181f9"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7183), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("f53f6c0a-35b8-402c-be00-5bfd2107c826"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7202), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("40bdef81-9230-4cc6-900b-b16a7d8f44fd"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7237), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("1fe46922-c109-4bf2-b000-0921272598a4"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7145), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("8f7127e6-b35f-400f-81e3-3acc7951174f"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7141), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("9f4cb41d-9558-4d9e-a2a6-fa720848aac5"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7143), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("a4863714-4de7-496b-92c1-b965cdb7f171"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7124), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("ddcf50e9-1f56-41fa-9c08-98c588b797d0"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7128), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("fb09d102-7d1d-4b89-a369-0efb28c36907"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7147), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "PostId", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2236583b-17fe-4be6-a352-4c08b452b230"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", null, "test-tag-slug", null },
                    { new Guid("b7606524-61a5-4f7e-83ba-1e161f80c1b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", null, "test-tag-slug-2", null },
                    { new Guid("cfab2ef3-3aaf-42b6-a7f6-b0060da8e5a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", null, "test-tag-slug-4", null },
                    { new Guid("d634ea1d-7bd9-41bc-9878-2dd191a0f11a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", null, "test-tag-slug-3", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("4b888a63-8eb7-4600-8210-962cfa214e02"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7419), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("64e76fbe-8524-420d-bafc-3f3db1c3bffd"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7417), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("9fc93f4e-778a-418f-8dea-096da6e81b43"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7409), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("c3ec7f8d-d928-48e5-81f8-c30bff3b0ae6"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7413), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("e81d43c0-605f-4299-8fdf-1ae63ea0383d"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7415), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7561));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("11904e37-4d3b-4516-a1cd-849df20ce6b7"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7579), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("21a49242-f262-44f4-b343-2561b24317ea"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7575), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("cb73ed73-8488-4d4f-a5c7-063b71d09987"), new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(7571), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("0de748a4-9c15-4d2f-bda5-7566c31da3c4"), null, "ali@asafarim.com", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(6851), new Guid("fe69cd68-dff4-4213-aac5-c13fa06859e6"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali", true, true, false, false, new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(6845), "Safari", null, "", "ali@asafarim.com", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, null, false, null, null, "https://example.com/profile.jpg", null, "ali@asafarim.com", new DateTime(2025, 2, 4, 20, 5, 57, 666, DateTimeKind.Utc).AddTicks(6853), new Guid("790c88fd-9fc1-4a86-91a9-e3f37ce57822"), null, null, null });
        }
    }
}
