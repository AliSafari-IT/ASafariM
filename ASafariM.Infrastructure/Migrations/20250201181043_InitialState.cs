using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0614b917-16d8-4fb4-a3ee-fffc48755323"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("16032238-ccc5-4d1a-ad70-5293e97af4fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("218beb0d-a067-41e4-bc0f-01615cfe888f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5378504d-1d3e-4191-af87-b64917aa7c2e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("625520bd-7f1b-4d33-8b3c-97797f47747e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("82c231d1-2252-4852-85b1-30affd8eda76"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9360a8b2-aca9-486b-afec-50745443aab0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b75c00e6-d678-4a75-91ee-9c7deb95079a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bbf61c4f-ed35-4661-9017-e48124d0da0d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fdd3ce3b-454f-4a84-bcf4-86f9fb6e1a4b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1489cab6-b1b2-4105-8388-e179f9b6a985"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5b1c2dbd-6335-496b-8cd1-8f6b1e870c08"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("707c64fd-332c-4fcd-b6b8-c09a1cec7631"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c5b749d5-b7fd-4a64-a028-4b806288b0bb"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("480d519a-c773-4e74-97e8-80a7b7a24ed3"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("8aee26d5-f204-4586-89aa-df79b8cb7d9c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("9ed1d3cc-dd95-4756-81e6-a5cafe541bb5"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("b93208d5-e3f9-4d7b-bbb2-c91806ae18fc"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("095ec5d8-581b-48fb-b444-fb84b4ba10e2"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("38077468-9446-4e69-9f4d-ef59ae4041eb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3b18c810-d159-4ebe-af61-66f892a3f50a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("4d618819-ce9e-40ac-be5a-dd2326319f27"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a17b81f4-384f-4037-96f6-5a7fd4fe3293"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f16b127c-b4d1-4938-b0f8-a5cb30994d75"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("b47cbac8-55f2-47e4-b14e-e0a7451ac858"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("287aa247-0789-49e0-953f-58d6484a6dd0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("75d5a158-b0ff-4640-91d8-0ba1e582d980"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b708454e-4758-413f-8908-8ccd1d715f31"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ca182bdc-3792-431c-a52d-150c43c345a4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("da9c4948-f48c-4429-b987-dada354ef2f1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ecdb0854-30e8-45db-a3bf-3019dd1760ae"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1c35b931-8441-499f-a899-5add6c54ecf7"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("2bbb02c3-450c-403e-8c09-c30d1d42b6d7"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("78b75327-0cdc-4375-b3cd-fbf12e386f9d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("8e3fe821-c8a1-4582-b7c5-d853d51284ca"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c22a3ead-0d91-4bc7-a269-f4b25cb21793"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("dad259aa-f545-4f25-a544-0153aeb79e1d"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("15ccd5a8-e398-4d50-8637-04841effc98a"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(708), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("19e96743-6913-4a41-b0d4-587ec98281ce"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(704), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("374e70f4-c0e8-4cb1-bf17-60aacd146bc3"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(692), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("43f057c1-382b-4a4c-bebf-2d7148d273bd"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(710), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("5628dde0-13f7-4cef-9701-299149277641"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(698), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("66c109fd-a5f4-48c9-ae4e-46e88a131d78"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(681), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("84a42325-d36c-4b5c-8921-3265c3c921c9"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(702), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("ae438ca8-081d-40c7-9160-d5294ff6c0d5"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(689), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("b72f736e-6aa7-4a02-a15e-4fae0896a8c2"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(700), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("be43ef52-4ace-4790-9ea6-50f645f59fd3"), "Brussels", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(694), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("ab6c5fcb-6144-4693-8272-2d1185f4f70f"), "EUR", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(594), 2, true, "Euro", "€", null },
                    { new Guid("cfd84606-078b-4c23-923e-bde4f48205bc"), "USD", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(599), 2, true, "US Dollar", "$", null },
                    { new Guid("ed93a947-19b2-49c9-8394-f8bb9a8c27c8"), "CHF", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(603), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("f66c4ee3-2947-464a-b800-ca40773257f8"), "GBP", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(601), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04d96b75-5097-4680-bfb9-11616fb95dd6"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(560), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("3f649798-b16b-49ff-888d-c5a2035cb71f"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(558), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("4fd7e444-7a38-46a6-9f9e-10d01fd313f1"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(556), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("99012232-e717-40aa-8b33-0943f177199f"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(553), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("37d28b79-860b-4d63-8aa3-af186d8a2160"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(487), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("59891f66-a2fb-46e1-b4bf-f10a05af08bd"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(482), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("a99e965e-736e-4fc1-91ef-8cd40e178da5"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(495), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("ea037967-0dbb-419c-9b5d-945205400b20"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(489), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("fa4e6118-506e-4e86-bd08-9007a5bb7113"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(497), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("fac0510b-fa42-4c0c-a638-1c6320588fdc"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(485), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("758b4a52-e172-4c7a-a016-11b91533e625"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(527), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("01303198-e36a-4a76-b49b-294e8f0f2b22"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("03639dc6-7bf0-480e-88a1-ea19452f6553"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("5e412feb-03e6-4794-8321-a9e09ac3289a"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("d1fdfb8f-4935-46d4-b786-4e2cef330b25"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("f0e0931f-fc2d-49c6-9a33-3ca910b38666"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("fcb098c5-1aff-487b-9f8d-1f1771f5de17"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name", "PostId", "Slug" },
                values: new object[] { new Guid("c3c407ec-bc32-4164-b202-15fd7b149396"), "Test Tag description", "Test Tag name", null, "test-tag-slug" });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("1558c101-867a-437b-8eef-3f7fa102b383"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(649), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("25ec0ccc-1080-4e78-aca1-d467aeda295e"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(644), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("2751c260-0531-41de-9dad-8ad1c22e9bc1"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(651), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("698e5908-6da3-4f20-990a-0e39595b3b5b"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(653), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("aaee6444-ed95-44c9-8697-4676ec130165"), new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(647), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("d9227b81-523a-402a-bd7a-4aed39c24207"), null, "ali@asafarim.com", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(172), new Guid("9852f2da-ac6c-4a0e-bd3d-001f9113e16c"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali", true, true, false, false, new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(166), "Safari", null, "", "ali@asafarim.com", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, null, false, null, null, "https://example.com/profile.jpg", null, "ali@asafarim.com", new DateTime(2025, 2, 1, 18, 10, 42, 199, DateTimeKind.Utc).AddTicks(174), new Guid("8b579ea3-692a-4906-a936-4442289d2278"), null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("15ccd5a8-e398-4d50-8637-04841effc98a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("19e96743-6913-4a41-b0d4-587ec98281ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("374e70f4-c0e8-4cb1-bf17-60aacd146bc3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("43f057c1-382b-4a4c-bebf-2d7148d273bd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5628dde0-13f7-4cef-9701-299149277641"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66c109fd-a5f4-48c9-ae4e-46e88a131d78"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("84a42325-d36c-4b5c-8921-3265c3c921c9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ae438ca8-081d-40c7-9160-d5294ff6c0d5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b72f736e-6aa7-4a02-a15e-4fae0896a8c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be43ef52-4ace-4790-9ea6-50f645f59fd3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ab6c5fcb-6144-4693-8272-2d1185f4f70f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cfd84606-078b-4c23-923e-bde4f48205bc"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ed93a947-19b2-49c9-8394-f8bb9a8c27c8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f66c4ee3-2947-464a-b800-ca40773257f8"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("04d96b75-5097-4680-bfb9-11616fb95dd6"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("3f649798-b16b-49ff-888d-c5a2035cb71f"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("4fd7e444-7a38-46a6-9f9e-10d01fd313f1"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("99012232-e717-40aa-8b33-0943f177199f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("37d28b79-860b-4d63-8aa3-af186d8a2160"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("59891f66-a2fb-46e1-b4bf-f10a05af08bd"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a99e965e-736e-4fc1-91ef-8cd40e178da5"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ea037967-0dbb-419c-9b5d-945205400b20"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fa4e6118-506e-4e86-bd08-9007a5bb7113"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fac0510b-fa42-4c0c-a638-1c6320588fdc"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("758b4a52-e172-4c7a-a016-11b91533e625"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("01303198-e36a-4a76-b49b-294e8f0f2b22"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("03639dc6-7bf0-480e-88a1-ea19452f6553"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5e412feb-03e6-4794-8321-a9e09ac3289a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d1fdfb8f-4935-46d4-b786-4e2cef330b25"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f0e0931f-fc2d-49c6-9a33-3ca910b38666"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fcb098c5-1aff-487b-9f8d-1f1771f5de17"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c3c407ec-bc32-4164-b202-15fd7b149396"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("1558c101-867a-437b-8eef-3f7fa102b383"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("25ec0ccc-1080-4e78-aca1-d467aeda295e"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("2751c260-0531-41de-9dad-8ad1c22e9bc1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("698e5908-6da3-4f20-990a-0e39595b3b5b"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("aaee6444-ed95-44c9-8697-4676ec130165"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d9227b81-523a-402a-bd7a-4aed39c24207"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0614b917-16d8-4fb4-a3ee-fffc48755323"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9221), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("16032238-ccc5-4d1a-ad70-5293e97af4fa"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9214), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("218beb0d-a067-41e4-bc0f-01615cfe888f"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9207), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("5378504d-1d3e-4191-af87-b64917aa7c2e"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9195), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("625520bd-7f1b-4d33-8b3c-97797f47747e"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9185), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("82c231d1-2252-4852-85b1-30affd8eda76"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9189), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("9360a8b2-aca9-486b-afec-50745443aab0"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9209), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("b75c00e6-d678-4a75-91ee-9c7deb95079a"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9212), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("bbf61c4f-ed35-4661-9017-e48124d0da0d"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9177), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("fdd3ce3b-454f-4a84-bcf4-86f9fb6e1a4b"), "Brussels", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9204), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1489cab6-b1b2-4105-8388-e179f9b6a985"), "USD", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9049), 2, true, "US Dollar", "$", null },
                    { new Guid("5b1c2dbd-6335-496b-8cd1-8f6b1e870c08"), "CHF", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9056), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("707c64fd-332c-4fcd-b6b8-c09a1cec7631"), "GBP", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9053), 2, true, "British Pound", "£", null },
                    { new Guid("c5b749d5-b7fd-4a64-a028-4b806288b0bb"), "EUR", new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9043), 2, true, "Euro", "€", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("480d519a-c773-4e74-97e8-80a7b7a24ed3"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8982), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("8aee26d5-f204-4586-89aa-df79b8cb7d9c"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8972), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("9ed1d3cc-dd95-4756-81e6-a5cafe541bb5"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8979), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("b93208d5-e3f9-4d7b-bbb2-c91806ae18fc"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8953), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("095ec5d8-581b-48fb-b444-fb84b4ba10e2"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8824), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("38077468-9446-4e69-9f4d-ef59ae4041eb"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8821), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("3b18c810-d159-4ebe-af61-66f892a3f50a"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8817), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("4d618819-ce9e-40ac-be5a-dd2326319f27"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8795), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("a17b81f4-384f-4037-96f6-5a7fd4fe3293"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8810), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("f16b127c-b4d1-4938-b0f8-a5cb30994d75"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8814), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("b47cbac8-55f2-47e4-b14e-e0a7451ac858"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(8900), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("287aa247-0789-49e0-953f-58d6484a6dd0"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("75d5a158-b0ff-4640-91d8-0ba1e582d980"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("b708454e-4758-413f-8908-8ccd1d715f31"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("ca182bdc-3792-431c-a52d-150c43c345a4"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("da9c4948-f48c-4429-b987-dada354ef2f1"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("ecdb0854-30e8-45db-a3bf-3019dd1760ae"), "Has full control over the application and can manage all aspects.", "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name", "PostId", "Slug" },
                values: new object[] { new Guid("1c35b931-8441-499f-a899-5add6c54ecf7"), "Test Tag description", "Test Tag name", null, "test-tag-slug" });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("2bbb02c3-450c-403e-8c09-c30d1d42b6d7"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9126), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("78b75327-0cdc-4375-b3cd-fbf12e386f9d"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9113), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("8e3fe821-c8a1-4582-b7c5-d853d51284ca"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9129), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("c22a3ead-0d91-4bc7-a269-f4b25cb21793"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9120), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("dad259aa-f545-4f25-a544-0153aeb79e1d"), new DateTime(2025, 2, 1, 17, 48, 30, 345, DateTimeKind.Utc).AddTicks(9123), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });
        }
    }
}
