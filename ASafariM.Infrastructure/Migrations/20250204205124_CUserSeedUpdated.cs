using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CUserSeedUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("0de4f439-979e-402b-9268-fecd4754fadf"), "Brussels", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9369), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("1c1ef08b-a205-4f1c-837f-74a7f2f3851f"), "Amsterdam", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9380), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("35b32066-404c-4b57-aad4-b3d761c61154"), "Bern", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9396), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("6333f0b7-13ed-4426-93ed-2f10de909e96"), "Luxembourg", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9403), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("65ebbf27-7aed-46ed-94a0-f4c55365316d"), "Paris", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9373), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("7582243a-f8fc-4d2d-ac50-f41161d25605"), "Madrid", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9393), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("c7111a3f-d217-4263-8590-afff5cd1be86"), "Vienna", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9400), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("c992cb25-7238-4356-964c-5e3882273cb5"), "Rome", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9390), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("e1fd46a1-b1ca-45e1-b305-884d7f37e1e3"), "Berlin", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9377), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("edce7c92-07ba-40b2-944b-fb94786a6246"), "London", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9383), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("00ceed27-80af-4037-afc0-d214f27a39d9"), "GBP", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9266), 2, true, "British Pound", "£", null },
                    { new Guid("4edc14ff-8b7f-4622-b612-69c62e11ea28"), "USD", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9264), 2, true, "US Dollar", "$", null },
                    { new Guid("a6d9c439-bb50-4073-83ce-35240c6e39cf"), "EUR", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9260), 2, true, "Euro", "€", null },
                    { new Guid("c1069751-4fc4-448b-845b-0a9034e3a493"), "CHF", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9268), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("27fa6c96-9e83-4dd3-9639-1f57f1a0f9f5"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9219), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("882bdb45-1ea7-4edb-8cb6-c1f8d4aa6fda"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9230), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("9613b2b9-580c-4cd2-9f0a-5344db91c9b6"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9225), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("ef3b600b-1201-4701-a8ee-967a34b6b9f2"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9223), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0139362a-1e92-4a91-8c3c-3e606ded8f4a"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9134), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("386e9ef4-e72d-4864-87ad-b29af84d66c4"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9139), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("50775f87-2e52-486e-9170-0faa2f0ec426"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9146), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("680e7f03-93c8-4e69-8f1c-f587713d6c2a"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9149), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("c2d6e251-cc31-470a-a62b-c6ee4e77f125"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9152), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("c61bb831-72ed-4124-a752-30354ee43a51"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9155), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("ca626e32-bbc1-40a7-af8d-bd4b12fb4770"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9191), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0ddf0088-da73-43bd-8810-a716534b84b6"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9092), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("37d1d28f-0734-41b7-9233-4544f3a9e33a"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9096), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("383fce43-3d4c-4301-a292-5777e81b855a"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9087), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("54541634-c02f-46ad-a2e6-619c1bd3ed8d"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9094), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("61927e6f-8b38-4b24-9390-c654ffb0c9a3"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9083), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("baf65ac9-b71b-4669-b3b3-39c3773dd6f1"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9090), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "PostId", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("96a6be48-6111-496e-b9a1-44bc35fe810e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", null, "test-tag-slug-2", null },
                    { new Guid("bef41693-fae7-4923-8b96-9370ecb16879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", null, "test-tag-slug", null },
                    { new Guid("db292f30-7adc-4516-89e9-49ee910d86dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", null, "test-tag-slug-3", null },
                    { new Guid("dc70e15e-4c28-421c-a954-b314a78ee68b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", null, "test-tag-slug-4", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("02687e1a-fc7a-4a49-97ec-caeed0dac4d6"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9298), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("63df4ade-9ac1-448c-ae54-8acb51816722"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9294), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("93ac40f0-589b-4703-87d4-a243d175fafb"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9322), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("9722795b-f79c-4f8c-8150-b3c4240ad0bc"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9300), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("ea6b48df-52c0-4303-8ccb-b8368d0fb0bc"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9324), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("b16e847b-7078-4e54-8e20-5ee788cb2ef0"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9497), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("b3d1d767-cf60-4931-bfe7-8f83a71122d8"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9504), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null },
                    { new Guid("fe8c9573-5c2c-411d-bd6b-16c65733c4a3"), new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(9502), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("523d99c4-d37b-46d2-88c4-0381681f0087"), null, "ali@asafarim.com", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(8830), new Guid("00bbf3f0-79b2-4e29-9ec5-996b2556b6a9"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali R.", true, true, false, false, new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(8822), "Safari", null, "ALI@ASAFARIM.COM", "ALIRZA", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, "+123456789", true, null, null, "https://asafarim.com/logoT.svg", null, "ali@asafarim.com", new DateTime(2025, 2, 4, 20, 51, 23, 674, DateTimeKind.Utc).AddTicks(8842), new Guid("9b6ee805-0200-467c-9901-9cbe452a8dfd"), null, "alireza", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0de4f439-979e-402b-9268-fecd4754fadf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c1ef08b-a205-4f1c-837f-74a7f2f3851f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("35b32066-404c-4b57-aad4-b3d761c61154"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6333f0b7-13ed-4426-93ed-2f10de909e96"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65ebbf27-7aed-46ed-94a0-f4c55365316d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7582243a-f8fc-4d2d-ac50-f41161d25605"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7111a3f-d217-4263-8590-afff5cd1be86"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c992cb25-7238-4356-964c-5e3882273cb5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1fd46a1-b1ca-45e1-b305-884d7f37e1e3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edce7c92-07ba-40b2-944b-fb94786a6246"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("00ceed27-80af-4037-afc0-d214f27a39d9"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("4edc14ff-8b7f-4622-b612-69c62e11ea28"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a6d9c439-bb50-4073-83ce-35240c6e39cf"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c1069751-4fc4-448b-845b-0a9034e3a493"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("27fa6c96-9e83-4dd3-9639-1f57f1a0f9f5"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("882bdb45-1ea7-4edb-8cb6-c1f8d4aa6fda"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("9613b2b9-580c-4cd2-9f0a-5344db91c9b6"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("ef3b600b-1201-4701-a8ee-967a34b6b9f2"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0139362a-1e92-4a91-8c3c-3e606ded8f4a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("386e9ef4-e72d-4864-87ad-b29af84d66c4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("50775f87-2e52-486e-9170-0faa2f0ec426"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("680e7f03-93c8-4e69-8f1c-f587713d6c2a"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c2d6e251-cc31-470a-a62b-c6ee4e77f125"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c61bb831-72ed-4124-a752-30354ee43a51"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("ca626e32-bbc1-40a7-af8d-bd4b12fb4770"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0ddf0088-da73-43bd-8810-a716534b84b6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("37d1d28f-0734-41b7-9233-4544f3a9e33a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("383fce43-3d4c-4301-a292-5777e81b855a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54541634-c02f-46ad-a2e6-619c1bd3ed8d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("61927e6f-8b38-4b24-9390-c654ffb0c9a3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("baf65ac9-b71b-4669-b3b3-39c3773dd6f1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("96a6be48-6111-496e-b9a1-44bc35fe810e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bef41693-fae7-4923-8b96-9370ecb16879"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("db292f30-7adc-4516-89e9-49ee910d86dc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dc70e15e-4c28-421c-a954-b314a78ee68b"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("02687e1a-fc7a-4a49-97ec-caeed0dac4d6"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("63df4ade-9ac1-448c-ae54-8acb51816722"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("93ac40f0-589b-4703-87d4-a243d175fafb"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9722795b-f79c-4f8c-8150-b3c4240ad0bc"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ea6b48df-52c0-4303-8ccb-b8368d0fb0bc"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b16e847b-7078-4e54-8e20-5ee788cb2ef0"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("b3d1d767-cf60-4931-bfe7-8f83a71122d8"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("fe8c9573-5c2c-411d-bd6b-16c65733c4a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("523d99c4-d37b-46d2-88c4-0381681f0087"));

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
        }
    }
}
