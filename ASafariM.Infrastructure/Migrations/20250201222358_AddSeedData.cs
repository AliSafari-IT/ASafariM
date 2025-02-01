using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("29798ded-7dca-4d43-b890-9ce67f67ce21"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7973), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("374d39c1-6b9c-467d-8d67-0ebee4f49662"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7983), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("3e2a4a64-3d6d-446a-a46b-24c5b98e3d24"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(8000), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("5c34582b-b005-447e-974c-a479b71bd7a6"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(8006), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("621a28a7-820a-4d49-a615-28e11216b724"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(8009), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("66cd13a0-a064-48a1-a891-17fbac149d25"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7995), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("6837156b-0ac3-4740-bfad-3978f7c2fbf2"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(8011), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("7916114e-0a73-4306-ae82-a361f4624e24"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7988), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("800eb7d0-04e2-44de-8de5-2631e1f075d0"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7986), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("aebaef2b-fb4c-40a3-a703-ebd585abc9cf"), "Brussels", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7998), true, "IT", "ITA", "Italy", "Italia", "+39", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("02e2f27a-6721-4983-b31d-a773f52d1db4"), "EUR", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7873), 2, true, "Euro", "€", null },
                    { new Guid("06c0c880-f64e-47b5-b31f-9fbd576b9488"), "CHF", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7883), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("0afb5124-b6ae-46bf-ab18-7237a6217282"), "USD", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7878), 2, true, "US Dollar", "$", null },
                    { new Guid("348fb592-d2a1-412f-bd50-f28d2b0d4e7e"), "GBP", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7880), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("a9620061-515b-4f82-a448-09c136d0b187"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7830), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("c191a5c8-a2b4-404f-b5f5-2af97c7d5571"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7824), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("d1341bd9-4eae-40b5-9768-f66b5317741c"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7828), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("df76092d-e1bc-4f29-ba72-ef692d30261c"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7833), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7b43ce1a-9a08-427d-9e72-90cb0099f862"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7728), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("8f07730b-e4de-4838-a11c-ebcd6d95f55f"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7739), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("95b6c338-8457-47a6-900f-4364faabfdd0"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7742), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("c52d01bd-d869-4829-a809-b3c4287a29fb"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7732), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("f179fc6e-4a1b-4b81-b446-2a8ab3a3aeec"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7744), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("fd040180-474b-4059-a93f-477d121615d4"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7724), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("59d36e59-fbac-4d91-a3a3-1610d728db80"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7788), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("3a200bb0-4bc0-4ad9-b373-ab125617509d"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("422f900e-79ef-47f5-b817-7e97d6bed31d"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("84152ce0-f662-44ac-9934-2f28f744c8bd"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("931233ee-fa19-4f71-a492-7bc5971c21b9"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("af3878f6-fd99-4e96-9a0b-13780fa441fe"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("e4eb56fb-4483-4a70-a94c-60a803128571"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name", "PostId", "Slug" },
                values: new object[,]
                {
                    { new Guid("0547e607-8fe1-42fb-a97a-8b51398f25c5"), "Test Tag description 4", "Test Tag name 4", null, "test-tag-slug-4" },
                    { new Guid("359d2f8b-e7f3-43a0-866d-2bdfd1429e49"), "Test Tag description", "Test Tag name", null, "test-tag-slug" },
                    { new Guid("9f9ea6ad-57cb-4505-a8c5-7e88550ab35b"), "Test Tag description 2", "Test Tag name 2", null, "test-tag-slug-2" },
                    { new Guid("f9f9cbcc-a897-4318-8237-15689d94c437"), "Test Tag description 3", "Test Tag name 3", null, "test-tag-slug-3" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("3b8f551a-4e20-4452-9dd0-d6cd2210d2bd"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7918), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("5450dd4c-1361-4fbc-8ae5-b5dac41e9518"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7922), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("85a50820-3dba-4a24-b47e-982d3893bd20"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7927), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("9a972d7d-ebd6-4443-bbf2-7391cf13580f"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7932), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("f6a2ce16-3042-42c7-aece-8b22d5f68a40"), new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7925), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Name", "ParentTopicId", "Slug" },
                values: new object[,]
                {
                    { new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "Test Topic description", "Test Topic name", null, "test-topic-slug" },
                    { new Guid("7d2edb5e-b8ad-46a2-9a86-bac4462e1a65"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("375a3094-2d52-434f-a618-066f927846e4"), null, "ali@asafarim.com", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7269), new Guid("ae243ba2-96e9-4ad0-9362-1ef85119e023"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali", true, true, false, false, new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7257), "Safari", null, "", "ali@asafarim.com", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, null, false, null, null, "https://example.com/profile.jpg", null, "ali@asafarim.com", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7271), new Guid("1ebcd7af-259f-4eac-87e4-9210898386f3"), null, null, null });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Name", "ParentTopicId", "Slug" },
                values: new object[,]
                {
                    { new Guid("609374af-26da-4732-a32a-eb0c13e07085"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2" },
                    { new Guid("a62e1eea-47b5-4d5a-922f-c2ab4919ee9d"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29798ded-7dca-4d43-b890-9ce67f67ce21"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("374d39c1-6b9c-467d-8d67-0ebee4f49662"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3e2a4a64-3d6d-446a-a46b-24c5b98e3d24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c34582b-b005-447e-974c-a479b71bd7a6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("621a28a7-820a-4d49-a615-28e11216b724"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("66cd13a0-a064-48a1-a891-17fbac149d25"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6837156b-0ac3-4740-bfad-3978f7c2fbf2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7916114e-0a73-4306-ae82-a361f4624e24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("800eb7d0-04e2-44de-8de5-2631e1f075d0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("aebaef2b-fb4c-40a3-a703-ebd585abc9cf"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("02e2f27a-6721-4983-b31d-a773f52d1db4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("06c0c880-f64e-47b5-b31f-9fbd576b9488"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("0afb5124-b6ae-46bf-ab18-7237a6217282"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("348fb592-d2a1-412f-bd50-f28d2b0d4e7e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("a9620061-515b-4f82-a448-09c136d0b187"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("c191a5c8-a2b4-404f-b5f5-2af97c7d5571"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d1341bd9-4eae-40b5-9768-f66b5317741c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("df76092d-e1bc-4f29-ba72-ef692d30261c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("7b43ce1a-9a08-427d-9e72-90cb0099f862"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("8f07730b-e4de-4838-a11c-ebcd6d95f55f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("95b6c338-8457-47a6-900f-4364faabfdd0"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c52d01bd-d869-4829-a809-b3c4287a29fb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("f179fc6e-4a1b-4b81-b446-2a8ab3a3aeec"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fd040180-474b-4059-a93f-477d121615d4"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("59d36e59-fbac-4d91-a3a3-1610d728db80"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3a200bb0-4bc0-4ad9-b373-ab125617509d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("422f900e-79ef-47f5-b817-7e97d6bed31d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("84152ce0-f662-44ac-9934-2f28f744c8bd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("931233ee-fa19-4f71-a492-7bc5971c21b9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("af3878f6-fd99-4e96-9a0b-13780fa441fe"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e4eb56fb-4483-4a70-a94c-60a803128571"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0547e607-8fe1-42fb-a97a-8b51398f25c5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("359d2f8b-e7f3-43a0-866d-2bdfd1429e49"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9f9ea6ad-57cb-4505-a8c5-7e88550ab35b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f9f9cbcc-a897-4318-8237-15689d94c437"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3b8f551a-4e20-4452-9dd0-d6cd2210d2bd"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5450dd4c-1361-4fbc-8ae5-b5dac41e9518"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("85a50820-3dba-4a24-b47e-982d3893bd20"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9a972d7d-ebd6-4443-bbf2-7391cf13580f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("f6a2ce16-3042-42c7-aece-8b22d5f68a40"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("609374af-26da-4732-a32a-eb0c13e07085"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7d2edb5e-b8ad-46a2-9a86-bac4462e1a65"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("a62e1eea-47b5-4d5a-922f-c2ab4919ee9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("375a3094-2d52-434f-a618-066f927846e4"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"));

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
    }
}
