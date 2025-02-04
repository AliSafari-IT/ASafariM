using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserPerefAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01bfde86-dfae-4af4-add6-d13dc692300c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("231b7a88-ff8a-4c8d-b5ac-fa377cd2ba75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("25f230c8-7ddc-4759-964a-671a3d44faec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4c322622-eef6-44db-8f76-e9867e4dc2af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("526d7a61-19a0-4c47-afb5-556192d20486"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("58a8ecd1-36b0-4393-a71b-c9b56ee7173b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b38bd193-f19e-4c8d-9b1a-fb0962545151"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4128e6b-540b-4f2a-bd3d-d4fd53931724"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c8ed0934-0159-45e0-a59c-efb0a765e110"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fd94ae17-9a34-400b-ae95-84f325855431"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("44ba01dc-675a-429e-9639-0722c78e8cc2"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("58330ed2-30fd-4471-ad87-f040a927ee9b"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a0fcfb5e-3d50-46a9-a00a-db618f26cfb2"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("cb3b2d0a-97eb-414d-b0c2-32606209b76a"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("30e5ed59-96fe-4ce7-a530-be6ba88a49db"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("3d9726de-0026-40bd-af75-6e7952136010"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("70b26f2f-c096-43f5-8e5d-4b60185aa7f9"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("dbc41107-7655-4191-ab70-2432a5cc5d39"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("2fa36df2-9933-4d88-b607-cce7b35e9575"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5d842911-63c6-4fa6-9251-5e72596573bf"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("628f5842-81c8-4bba-aad5-69423d84aae5"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9cc9085d-c30f-410d-9497-440a0aec9a7f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d0ad0b6f-8fb6-401b-b1df-1b5f258cb63c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d7e54b5e-5f76-40e9-a043-8c2c8c72eb34"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("ccd6d22a-facf-4e02-93fa-07c578ccfcc9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("30cf3ebb-37a0-47ce-9c0b-16ac1d351e42"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("65070418-3d45-4f68-8cef-59028d235b71"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("65f37be7-def9-4315-aaf7-5573932ed7e3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8fd530d3-4398-4b62-9fa4-6ce188b8feaa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9868d1e4-0030-4d45-a8bd-cb1e017f298c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b3b8cdf6-7028-4271-a3f5-3630c64d50dc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5278be27-69dc-4688-81e9-5efd88304044"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("58982553-d6af-4178-818f-4e7b8549e019"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7edd55fb-0d30-4c90-9f45-c33b67cb89e9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a9748df9-2714-453c-ae30-b740a88a82c9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("17833bc8-3498-40f7-b969-476339c2d979"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3e815934-7e81-41e0-aeb0-070bad29faf1"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("413a2ba4-f9f9-48a2-bc9c-c889bd0e19ee"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9a70ca49-ce5f-4b0e-9d65-fc04cc3bdebc"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("b1110a38-6076-4f9b-99ef-ed205745d109"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("00658012-54f6-4e7d-98fe-e0c2bcaf99f8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("046f6f19-12b3-4c3b-a151-bb91c85900f0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("5e511121-05ef-4363-b1b7-7882759d1957"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bf8a5d8-7e3f-4304-8c01-c12cbaebbb80"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("01bfde86-dfae-4af4-add6-d13dc692300c"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9277), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("231b7a88-ff8a-4c8d-b5ac-fa377cd2ba75"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9285), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("25f230c8-7ddc-4759-964a-671a3d44faec"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9272), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("4c322622-eef6-44db-8f76-e9867e4dc2af"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9265), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("526d7a61-19a0-4c47-afb5-556192d20486"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9270), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("58a8ecd1-36b0-4393-a71b-c9b56ee7173b"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9262), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("b38bd193-f19e-4c8d-9b1a-fb0962545151"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9283), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("b4128e6b-540b-4f2a-bd3d-d4fd53931724"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9281), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("c8ed0934-0159-45e0-a59c-efb0a765e110"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9288), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("fd94ae17-9a34-400b-ae95-84f325855431"), "Brussels", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9279), true, "IT", "ITA", "Italy", "Italia", "+39", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("44ba01dc-675a-429e-9639-0722c78e8cc2"), "GBP", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9183), 2, true, "British Pound", "£", null },
                    { new Guid("58330ed2-30fd-4471-ad87-f040a927ee9b"), "CHF", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9188), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("a0fcfb5e-3d50-46a9-a00a-db618f26cfb2"), "EUR", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9170), 2, true, "Euro", "€", null },
                    { new Guid("cb3b2d0a-97eb-414d-b0c2-32606209b76a"), "USD", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9180), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("30e5ed59-96fe-4ce7-a530-be6ba88a49db"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9142), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("3d9726de-0026-40bd-af75-6e7952136010"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9138), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("70b26f2f-c096-43f5-8e5d-4b60185aa7f9"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9136), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("dbc41107-7655-4191-ab70-2432a5cc5d39"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9132), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2fa36df2-9933-4d88-b607-cce7b35e9575"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9066), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("5d842911-63c6-4fa6-9251-5e72596573bf"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9068), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("628f5842-81c8-4bba-aad5-69423d84aae5"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9061), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("9cc9085d-c30f-410d-9497-440a0aec9a7f"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9070), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("d0ad0b6f-8fb6-401b-b1df-1b5f258cb63c"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9064), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("d7e54b5e-5f76-40e9-a043-8c2c8c72eb34"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9058), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("ccd6d22a-facf-4e02-93fa-07c578ccfcc9"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9107), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("30cf3ebb-37a0-47ce-9c0b-16ac1d351e42"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("65070418-3d45-4f68-8cef-59028d235b71"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("65f37be7-def9-4315-aaf7-5573932ed7e3"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("8fd530d3-4398-4b62-9fa4-6ce188b8feaa"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("9868d1e4-0030-4d45-a8bd-cb1e017f298c"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("b3b8cdf6-7028-4271-a3f5-3630c64d50dc"), "Has full control over the application and can manage all aspects.", "SuperAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name", "PostId", "Slug" },
                values: new object[,]
                {
                    { new Guid("5278be27-69dc-4688-81e9-5efd88304044"), "Test Tag description 3", "Test Tag name 3", null, "test-tag-slug-3" },
                    { new Guid("58982553-d6af-4178-818f-4e7b8549e019"), "Test Tag description 2", "Test Tag name 2", null, "test-tag-slug-2" },
                    { new Guid("7edd55fb-0d30-4c90-9f45-c33b67cb89e9"), "Test Tag description 4", "Test Tag name 4", null, "test-tag-slug-4" },
                    { new Guid("a9748df9-2714-453c-ae30-b740a88a82c9"), "Test Tag description", "Test Tag name", null, "test-tag-slug" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("17833bc8-3498-40f7-b969-476339c2d979"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9231), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("3e815934-7e81-41e0-aeb0-070bad29faf1"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9227), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("413a2ba4-f9f9-48a2-bc9c-c889bd0e19ee"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9222), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("9a70ca49-ce5f-4b0e-9d65-fc04cc3bdebc"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9229), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("b1110a38-6076-4f9b-99ef-ed205745d109"), new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(9233), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "Description", "Name", "ParentTopicId", "Slug" },
                values: new object[,]
                {
                    { new Guid("00658012-54f6-4e7d-98fe-e0c2bcaf99f8"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3" },
                    { new Guid("046f6f19-12b3-4c3b-a151-bb91c85900f0"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4" },
                    { new Guid("5e511121-05ef-4363-b1b7-7882759d1957"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("7bf8a5d8-7e3f-4304-8c01-c12cbaebbb80"), null, "ali@asafarim.com", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(8605), new Guid("13fb277d-50a9-4e62-bc3b-72a3fe6516cd"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali", true, true, false, false, new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(8597), "Safari", null, "", "ali@asafarim.com", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, null, false, null, null, "https://example.com/profile.jpg", null, "ali@asafarim.com", new DateTime(2025, 2, 3, 17, 19, 56, 271, DateTimeKind.Utc).AddTicks(8606), new Guid("5751a65c-8d9e-4922-acad-6e7a1642b780"), null, null, null });
        }
    }
}
