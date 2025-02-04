using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DbUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("04d7f6c2-c02d-4700-b0a6-f740a78965c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0cf265d1-7d85-491e-ba4f-5c67378060d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("302db356-a2d3-4490-8758-cc628f3073ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ec40b58-0fbd-4803-af37-d10af26ea79d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b50c103-d37d-4196-921e-74d08569fc5f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("92bf0b6a-94cd-404d-bc8f-719518e3e0fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("982de5ea-42cb-4a3d-b580-d8cd65e7509e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("accec0b7-b708-45cd-bea0-bb6b97e665e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e7910642-2633-4067-bc54-878812829ab3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e9043aa7-fec4-4c1e-8c06-269c8b9a2031"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("28bf5759-722b-4f1e-976f-d2d153a29fa9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("5f99b0dc-5c07-48ed-bf1e-ef3987e93db3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("ac9e96cf-d2d8-4a37-9dd7-7628529862f8"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f605d517-1414-48c6-b061-4db1504f28b4"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0f968d5f-5838-4c75-9247-b161b146020c"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("181fac3b-b466-4786-ae82-305673584281"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("1b7b3e31-3156-4244-954a-7b47e8613df3"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("f4a0b2cc-74e0-4805-a2c9-c11fda22954f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("22550b99-f908-401c-9e61-5466f30aeb4f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("6250b4e6-d528-4ce7-9373-41205ae725fa"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b1a90e55-0d65-4545-8de5-d83c10b74115"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("bb331e88-3c81-48c0-93f9-56b7e9537f4f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d04f0d72-ea25-41ea-b38a-00f834a9ea7a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d5169542-c828-42aa-be96-51bce750cbeb"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("d27cf287-384d-4e2b-acd1-602b5a258a6f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("597ddc4e-637d-4362-adea-c3df26bc332e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5badc4fe-225c-4e93-8abe-c4ce8895aeb5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("744b4270-7951-42f8-935c-d33fa07183e9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e4ce956-d401-4d9f-9bac-98725491c747"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dbe528ff-7bf0-4493-8345-46d0901afbf1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("de68c4be-ea73-4d00-8caf-ad3aa6927ccd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("50699b91-6958-4512-a3ab-e538e8d59de4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6006f47e-aa01-4e4d-ba8d-07a2315cb1cf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b1a7a8e5-8115-4c84-9508-ca46637239c4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("db9ea76b-f59c-4753-b5d7-562251c3126b"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("4c417eb4-56f5-4869-9c5e-7a5894d8c73c"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("59034446-6a13-457d-af50-e486354efac6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("635cf4db-0e67-445c-866b-3484a7982493"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("93f1ff6d-4301-4c6a-9dac-a7c5f40a40b6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c4e8a3f4-a064-46c3-93c0-221e42b086a0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("00ffb327-68b5-49c9-8e8e-47d00afcd14a"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5e836636-894e-4289-8ad9-dae2a700c479"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b5b89d72-4f37-4e8b-9459-c317babb869f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d5d88ac-3d74-4824-a5b3-310513230cb8"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0c84b63c-3aaf-401a-ab89-1ddfd168c425"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2246), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("119ddd63-349c-4605-ae7c-8b22044c3695"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2260), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("76010a8b-fca6-4e07-87a0-eee656b0ec9b"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2268), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("919285c7-4321-4d05-805e-8b8cbab60a4b"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2256), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("97de5665-71dc-44cb-bd32-c34f5a887c03"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2235), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("a80e01b9-10cd-4a53-87b6-724cbf5c010d"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2266), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("bc8c9494-7574-4419-b98e-0f1aef2c215f"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2248), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("bdede0f3-5d22-4c60-a239-8c1cbf86811f"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2262), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("be924927-dc8f-44ee-949e-b750ee0f96bc"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2243), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("c5c4ee68-cfed-4881-a8ee-05d7da3eab04"), "Brussels", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2258), true, "IT", "ITA", "Italy", "Italia", "+39", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1d8acd51-7df4-4808-822c-0ea23178c72e"), "CHF", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2134), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("609e12f9-e2e5-4807-997a-b0999edba87a"), "EUR", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2126), 2, true, "Euro", "€", null },
                    { new Guid("b7319adc-1228-4171-8d6e-c0776062e813"), "GBP", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2132), 2, true, "British Pound", "£", null },
                    { new Guid("d92cba17-a2da-4342-998d-737a2976cd57"), "USD", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2130), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("4549ddd5-3d56-423f-b38e-127bc8351088"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2081), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("ae2039d7-e8bc-40a8-8347-571d237ddffc"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2085), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("dc4a18c9-2b8e-4c18-a8ba-c65ae49f4e14"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2087), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("e238e772-d2e4-4e44-96c0-f1246c52d864"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2075), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("039c73a8-1c9f-4d76-a640-5882564c371e"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1987), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("1bede028-295c-4271-9e49-aeca5947694b"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1985), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("8a7b03be-65f7-457a-8ad0-53516a85cb7a"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1989), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("b925af46-9f4c-4c00-93a2-ceac7e24b68b"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1975), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("ba8ec0fd-fb0c-4648-9c9f-53491c0b7115"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1982), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("fc3312e4-b22f-462f-84cd-a10128931c9c"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1980), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("e653ddff-4e10-4e20-9aeb-891e2c415a1f"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2025), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("41daa6bc-5251-40eb-9526-68f0a6ed2d28"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("69448867-8107-4487-afde-cdafc8906c43"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("a7967abb-339e-4c8f-a107-af5a672b64ad"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("e30bf5de-cb5d-4939-b38e-55f7e390d3bb"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("e3d92d51-047b-4aa3-97c7-accb9ad64074"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("fbc098b9-1936-4a28-9026-63b02f44418a"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name", "PostId", "Slug" },
                values: new object[,]
                {
                    { new Guid("0151497b-ea10-4d29-9f0b-b40c3feed43c"), "Test Tag description 2", "Test Tag name 2", null, "test-tag-slug-2" },
                    { new Guid("6fd87129-4455-4563-95e4-68c79f67dfa9"), "Test Tag description", "Test Tag name", null, "test-tag-slug" },
                    { new Guid("cbcfb14d-30a1-4af5-bebb-02ea598efb34"), "Test Tag description 4", "Test Tag name 4", null, "test-tag-slug-4" },
                    { new Guid("ffd50d59-ffa5-4553-825a-f6bfed515e3c"), "Test Tag description 3", "Test Tag name 3", null, "test-tag-slug-3" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("18430302-e5f6-4bb7-8206-3d03ec31d651"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2199), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("29b49fb4-a022-4dd5-98db-c35b35b59286"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2197), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("a3da1ef3-41aa-40ec-9b52-ee58f7def33f"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2186), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("d9290cb1-3127-44d2-8e72-95f5fa66c972"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2195), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("fbba4332-b08e-4cee-bea7-84ebb49e5ab6"), new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(2193), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Name", "ParentTopicId", "Slug" },
                values: new object[,]
                {
                    { new Guid("80d814ac-5605-4739-a697-2b6ab6ce8ccf"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4" },
                    { new Guid("9e45276b-5dcc-4c28-9fac-ded0eb129c87"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2" },
                    { new Guid("f02c9cf6-5e23-46b4-98f1-aaac5a00bfd5"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("8e03b95e-6eca-4415-b7d0-7252e486f627"), null, "ali@asafarim.com", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1582), new Guid("5ab2a9ad-9696-4175-a707-23f00de34133"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali", true, true, false, false, new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1575), "Safari", null, "", "ali@asafarim.com", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, null, false, null, null, "https://example.com/profile.jpg", null, "ali@asafarim.com", new DateTime(2025, 2, 3, 17, 23, 31, 24, DateTimeKind.Utc).AddTicks(1584), new Guid("d15e7122-665b-4c98-8842-fe314e96cadb"), null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c84b63c-3aaf-401a-ab89-1ddfd168c425"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("119ddd63-349c-4605-ae7c-8b22044c3695"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76010a8b-fca6-4e07-87a0-eee656b0ec9b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("919285c7-4321-4d05-805e-8b8cbab60a4b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97de5665-71dc-44cb-bd32-c34f5a887c03"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a80e01b9-10cd-4a53-87b6-724cbf5c010d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bc8c9494-7574-4419-b98e-0f1aef2c215f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bdede0f3-5d22-4c60-a239-8c1cbf86811f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("be924927-dc8f-44ee-949e-b750ee0f96bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c5c4ee68-cfed-4881-a8ee-05d7da3eab04"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("1d8acd51-7df4-4808-822c-0ea23178c72e"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("609e12f9-e2e5-4807-997a-b0999edba87a"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("b7319adc-1228-4171-8d6e-c0776062e813"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d92cba17-a2da-4342-998d-737a2976cd57"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("4549ddd5-3d56-423f-b38e-127bc8351088"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ae2039d7-e8bc-40a8-8347-571d237ddffc"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("dc4a18c9-2b8e-4c18-a8ba-c65ae49f4e14"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("e238e772-d2e4-4e44-96c0-f1246c52d864"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("039c73a8-1c9f-4d76-a640-5882564c371e"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("1bede028-295c-4271-9e49-aeca5947694b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("8a7b03be-65f7-457a-8ad0-53516a85cb7a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("b925af46-9f4c-4c00-93a2-ceac7e24b68b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("ba8ec0fd-fb0c-4648-9c9f-53491c0b7115"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fc3312e4-b22f-462f-84cd-a10128931c9c"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("e653ddff-4e10-4e20-9aeb-891e2c415a1f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("41daa6bc-5251-40eb-9526-68f0a6ed2d28"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("69448867-8107-4487-afde-cdafc8906c43"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a7967abb-339e-4c8f-a107-af5a672b64ad"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e30bf5de-cb5d-4939-b38e-55f7e390d3bb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e3d92d51-047b-4aa3-97c7-accb9ad64074"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fbc098b9-1936-4a28-9026-63b02f44418a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0151497b-ea10-4d29-9f0b-b40c3feed43c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6fd87129-4455-4563-95e4-68c79f67dfa9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cbcfb14d-30a1-4af5-bebb-02ea598efb34"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ffd50d59-ffa5-4553-825a-f6bfed515e3c"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("18430302-e5f6-4bb7-8206-3d03ec31d651"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("29b49fb4-a022-4dd5-98db-c35b35b59286"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("a3da1ef3-41aa-40ec-9b52-ee58f7def33f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("d9290cb1-3127-44d2-8e72-95f5fa66c972"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("fbba4332-b08e-4cee-bea7-84ebb49e5ab6"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("80d814ac-5605-4739-a697-2b6ab6ce8ccf"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("9e45276b-5dcc-4c28-9fac-ded0eb129c87"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("f02c9cf6-5e23-46b4-98f1-aaac5a00bfd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e03b95e-6eca-4415-b7d0-7252e486f627"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04d7f6c2-c02d-4700-b0a6-f740a78965c3"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3687), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("0cf265d1-7d85-491e-ba4f-5c67378060d2"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3676), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("302db356-a2d3-4490-8758-cc628f3073ce"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3674), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("3ec40b58-0fbd-4803-af37-d10af26ea79d"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3671), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("6b50c103-d37d-4196-921e-74d08569fc5f"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3682), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("92bf0b6a-94cd-404d-bc8f-719518e3e0fb"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3689), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("982de5ea-42cb-4a3d-b580-d8cd65e7509e"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3696), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("accec0b7-b708-45cd-bea0-bb6b97e665e3"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3662), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("e7910642-2633-4067-bc54-878812829ab3"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3685), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("e9043aa7-fec4-4c1e-8c06-269c8b9a2031"), "Brussels", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3694), true, "AT", "AUT", "Austria", "Österreich", "+43", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("28bf5759-722b-4f1e-976f-d2d153a29fa9"), "EUR", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3568), 2, true, "Euro", "€", null },
                    { new Guid("5f99b0dc-5c07-48ed-bf1e-ef3987e93db3"), "CHF", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3580), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("ac9e96cf-d2d8-4a37-9dd7-7628529862f8"), "GBP", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3578), 2, true, "British Pound", "£", null },
                    { new Guid("f605d517-1414-48c6-b061-4db1504f28b4"), "USD", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3575), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f968d5f-5838-4c75-9247-b161b146020c"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3537), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("181fac3b-b466-4786-ae82-305673584281"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3531), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("1b7b3e31-3156-4244-954a-7b47e8613df3"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3534), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("f4a0b2cc-74e0-4805-a2c9-c11fda22954f"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3539), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("22550b99-f908-401c-9e61-5466f30aeb4f"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3427), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("6250b4e6-d528-4ce7-9373-41205ae725fa"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3418), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("b1a90e55-0d65-4545-8de5-d83c10b74115"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3408), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("bb331e88-3c81-48c0-93f9-56b7e9537f4f"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3424), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("d04f0d72-ea25-41ea-b38a-00f834a9ea7a"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3416), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("d5169542-c828-42aa-be96-51bce750cbeb"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3413), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("d27cf287-384d-4e2b-acd1-602b5a258a6f"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3501), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("597ddc4e-637d-4362-adea-c3df26bc332e"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("5badc4fe-225c-4e93-8abe-c4ce8895aeb5"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("744b4270-7951-42f8-935c-d33fa07183e9"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("9e4ce956-d401-4d9f-9bac-98725491c747"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("dbe528ff-7bf0-4493-8345-46d0901afbf1"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("de68c4be-ea73-4d00-8caf-ad3aa6927ccd"), "Has full control over the application and can manage all aspects.", "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name", "PostId", "Slug" },
                values: new object[,]
                {
                    { new Guid("50699b91-6958-4512-a3ab-e538e8d59de4"), "Test Tag description", "Test Tag name", null, "test-tag-slug" },
                    { new Guid("6006f47e-aa01-4e4d-ba8d-07a2315cb1cf"), "Test Tag description 2", "Test Tag name 2", null, "test-tag-slug-2" },
                    { new Guid("b1a7a8e5-8115-4c84-9508-ca46637239c4"), "Test Tag description 3", "Test Tag name 3", null, "test-tag-slug-3" },
                    { new Guid("db9ea76b-f59c-4753-b5d7-562251c3126b"), "Test Tag description 4", "Test Tag name 4", null, "test-tag-slug-4" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("4c417eb4-56f5-4869-9c5e-7a5894d8c73c"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3618), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("59034446-6a13-457d-af50-e486354efac6"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3621), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("635cf4db-0e67-445c-866b-3484a7982493"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3623), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("93f1ff6d-4301-4c6a-9dac-a7c5f40a40b6"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3615), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("c4e8a3f4-a064-46c3-93c0-221e42b086a0"), new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(3625), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Name", "ParentTopicId", "Slug" },
                values: new object[,]
                {
                    { new Guid("00ffb327-68b5-49c9-8e8e-47d00afcd14a"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3" },
                    { new Guid("5e836636-894e-4289-8ad9-dae2a700c479"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2" },
                    { new Guid("b5b89d72-4f37-4e8b-9459-c317babb869f"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("8d5d88ac-3d74-4824-a5b3-310513230cb8"), null, "ali@asafarim.com", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(2875), new Guid("e9cd0b61-51ad-485d-b897-038f28b5ddaf"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali", true, true, false, false, new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(2866), "Safari", null, "", "ali@asafarim.com", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, null, false, null, null, "https://example.com/profile.jpg", null, "ali@asafarim.com", new DateTime(2025, 2, 3, 17, 20, 36, 84, DateTimeKind.Utc).AddTicks(2876), new Guid("629f9392-b67a-407a-8c26-8d7862818275"), null, null, null });
        }
    }
}
