using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("06c39fd6-b19e-4b0b-8038-2c05cb955b2b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("075896a4-0aae-4034-8fe4-11a1836b8a58"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a31df74-d323-4f2e-ae4c-eee2d69d97d3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("16dcbcf3-0c1b-4f7a-b245-049881753c28"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("32a1f34a-eb18-49b3-a67e-442b5d0f246b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8befcafa-f71e-4186-b791-0c3d7c7de584"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("91f0b59e-b285-47e0-be82-02d0946d5d91"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b428e215-909b-4c30-a929-ac5142c1dff0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e0558e0c-ace9-43b2-bd0e-8361acabd029"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f080f360-ab57-45e3-9071-21a166192759"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("2ad937eb-c0f5-485b-85d1-c6d652e05d96"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3cad0f64-4f4a-488a-a3de-ef4da85dfbaa"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a81e5c05-aaee-422c-9654-20f81d483d1d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("bef8c5a6-1e20-4d64-99ea-ae14b40b6c7f"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0848f5c1-4032-461f-95f2-db372f5ce95e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("19423c17-9d1d-4a94-bd03-bcb3a144508e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("67607140-ad1b-4d9c-9bff-1d4b1c9f8bfe"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("796739f3-35f7-41f7-af89-14d1a5dfcb7e"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3a4ed5d3-8a8a-4a32-8452-94cb2ecdd05e"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3ba0691d-c252-49f0-9cf9-abc3b9d95273"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("46ca04ef-df68-46f0-a218-60d3f2a912c4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("7690ff48-78dd-408c-8a6a-7e0d3f7b674b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a5e68865-6f97-4233-bd72-4bb7a83b988b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("eea12633-8982-415a-a811-e91f71e8efe8"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("d3d2bf12-6557-44ff-b6f3-29af32396095"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1b4a568a-9141-4cdb-b1bc-233046767fd7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("34519611-79ce-409b-942e-a96ca64b5d97"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68ab3a93-84ad-4869-8231-affad9912cf1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9514455f-ca2d-48dd-bfc2-faa8350410ba"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a05dfeb9-04be-4a12-a40f-3901917d2beb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c9897771-7e4c-48d7-afbf-4d2a86862eca"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("359b6e4f-f832-45f2-b98c-2fe1784bb3b9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9552ad10-6e3b-440b-a86c-bd5ce8fa84cb"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("b0fcdb72-a2c7-47e4-8fa9-4a23e3c6e20a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ba20b8b2-2040-4f6e-9592-2f96aa8559dd"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("ea7ef0bb-ce54-4707-93b4-30c8641605ed"));

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Tags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tags",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Tags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0e292ee3-d1f5-4700-8ec4-f8a7fb18b51e"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3328), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("0e523bcd-3903-41a9-be92-8e072be9f62f"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3346), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("281d24eb-efb2-4417-a7cf-8f6b3d4a2923"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3333), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("7f687c5e-ae62-46b5-a2c9-69e3252f64b4"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3344), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("88dc15d6-5256-4216-9ad4-65aa3bd3488a"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3348), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("a473fa3b-8f59-4362-aaa2-c4714d90a735"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3324), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("b4cfd6b1-413d-4695-8976-c99cb70f90df"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3357), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("c0aa51b9-d7af-4461-b5b7-f61ac55c8306"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3340), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("c122382d-95da-4a9e-99e9-aa76e982574d"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3335), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("d091671c-c44b-41cf-b4da-644fc51d2d54"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3342), true, "IT", "ITA", "Italy", "Italia", "+39", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("7a98c886-278e-478c-b63f-f462f08140c3"), "USD", new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3218), 2, true, "US Dollar", "$", null },
                    { new Guid("a3035776-d93b-456d-bf7f-0a93296883e1"), "EUR", new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3216), 2, true, "Euro", "€", null },
                    { new Guid("aafd050c-817c-4061-911c-1a7b9dd406b0"), "CHF", new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3224), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("c713c361-1064-489d-8b73-e0dde2325a2e"), "GBP", new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3220), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0d76e136-3343-400e-bfba-29f8c8bb0f81"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3178), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("1ad59dbb-9ffc-4bf9-987e-16aa916f0192"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3181), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("8502ecd0-8a3c-4284-b806-b9b33e5974da"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3182), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("d4ce894e-8557-4843-a001-49db2e3ab3f9"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3176), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04171c1d-ad74-4b46-aa7f-3f032e39e261"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3108), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("82e6d3e5-062c-4f70-ba35-d271573e4b41"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3106), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("9d1b28b2-45a5-41a8-a35c-a26e16bfb87f"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3100), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("a3931c78-e54f-4582-9716-75ad7e98f3d1"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3102), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("bee8ddc7-9c4f-4146-bb44-699840fbe788"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3105), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("c1ddd61f-dc39-47d0-9cbf-07884bbcd1be"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3094), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("e6461d43-a6af-4540-a2c6-909bc13b4b61"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3147), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("0656085c-27b3-4f87-9b17-39e01eb8ef3c"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("a6570115-ea9a-4aea-86af-3fe18494938d"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("b23f9dcd-edfc-4265-bc23-6db3f53a49c3"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("baf088e8-7985-4fa1-acbf-873ec62f19aa"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("cfdbc410-bcd3-42b4-a626-d2b527010916"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("d0af760a-7db4-484f-b09e-2636741245b5"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("2919702b-cd76-4993-b188-f5b22a08cef4"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3269), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("351390d0-4117-47af-8c5f-6768fba2956a"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3272), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("41ad770c-db58-4e4f-ada0-aab07340ed2a"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3263), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("7dbaa3d3-5b84-4c10-ae03-0a4f24ea4161"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3266), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("fc4e41a4-06cd-4881-b536-1cf918c21db9"), new DateTime(2025, 1, 30, 19, 28, 5, 556, DateTimeKind.Utc).AddTicks(3270), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e292ee3-d1f5-4700-8ec4-f8a7fb18b51e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e523bcd-3903-41a9-be92-8e072be9f62f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("281d24eb-efb2-4417-a7cf-8f6b3d4a2923"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f687c5e-ae62-46b5-a2c9-69e3252f64b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("88dc15d6-5256-4216-9ad4-65aa3bd3488a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a473fa3b-8f59-4362-aaa2-c4714d90a735"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b4cfd6b1-413d-4695-8976-c99cb70f90df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0aa51b9-d7af-4461-b5b7-f61ac55c8306"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c122382d-95da-4a9e-99e9-aa76e982574d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d091671c-c44b-41cf-b4da-644fc51d2d54"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("7a98c886-278e-478c-b63f-f462f08140c3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("a3035776-d93b-456d-bf7f-0a93296883e1"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("aafd050c-817c-4061-911c-1a7b9dd406b0"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c713c361-1064-489d-8b73-e0dde2325a2e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0d76e136-3343-400e-bfba-29f8c8bb0f81"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("1ad59dbb-9ffc-4bf9-987e-16aa916f0192"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("8502ecd0-8a3c-4284-b806-b9b33e5974da"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d4ce894e-8557-4843-a001-49db2e3ab3f9"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("04171c1d-ad74-4b46-aa7f-3f032e39e261"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("82e6d3e5-062c-4f70-ba35-d271573e4b41"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9d1b28b2-45a5-41a8-a35c-a26e16bfb87f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a3931c78-e54f-4582-9716-75ad7e98f3d1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("bee8ddc7-9c4f-4146-bb44-699840fbe788"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c1ddd61f-dc39-47d0-9cbf-07884bbcd1be"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("e6461d43-a6af-4540-a2c6-909bc13b4b61"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0656085c-27b3-4f87-9b17-39e01eb8ef3c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a6570115-ea9a-4aea-86af-3fe18494938d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b23f9dcd-edfc-4265-bc23-6db3f53a49c3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("baf088e8-7985-4fa1-acbf-873ec62f19aa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cfdbc410-bcd3-42b4-a626-d2b527010916"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d0af760a-7db4-484f-b09e-2636741245b5"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("2919702b-cd76-4993-b188-f5b22a08cef4"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("351390d0-4117-47af-8c5f-6768fba2956a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("41ad770c-db58-4e4f-ada0-aab07340ed2a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7dbaa3d3-5b84-4c10-ae03-0a4f24ea4161"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("fc4e41a4-06cd-4881-b536-1cf918c21db9"));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "UpdatedBy",
                keyValue: null,
                column: "UpdatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Tags",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tags",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "CreatedBy",
                keyValue: null,
                column: "CreatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Tags",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("06c39fd6-b19e-4b0b-8038-2c05cb955b2b"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3026), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("075896a4-0aae-4034-8fe4-11a1836b8a58"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3038), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("0a31df74-d323-4f2e-ae4c-eee2d69d97d3"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3022), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("16dcbcf3-0c1b-4f7a-b245-049881753c28"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3037), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("32a1f34a-eb18-49b3-a67e-442b5d0f246b"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3017), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("8befcafa-f71e-4186-b791-0c3d7c7de584"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3024), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("91f0b59e-b285-47e0-be82-02d0946d5d91"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3020), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("b428e215-909b-4c30-a929-ac5142c1dff0"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3035), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("e0558e0c-ace9-43b2-bd0e-8361acabd029"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3030), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("f080f360-ab57-45e3-9071-21a166192759"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(3028), true, "IT", "ITA", "Italy", "Italia", "+39", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2ad937eb-c0f5-485b-85d1-c6d652e05d96"), "CHF", new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2952), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("3cad0f64-4f4a-488a-a3de-ef4da85dfbaa"), "GBP", new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2950), 2, true, "British Pound", "£", null },
                    { new Guid("a81e5c05-aaee-422c-9654-20f81d483d1d"), "EUR", new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2945), 2, true, "Euro", "€", null },
                    { new Guid("bef8c5a6-1e20-4d64-99ea-ae14b40b6c7f"), "USD", new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2948), 2, true, "US Dollar", "$", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0848f5c1-4032-461f-95f2-db372f5ce95e"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2915), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("19423c17-9d1d-4a94-bd03-bcb3a144508e"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2913), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("67607140-ad1b-4d9c-9bff-1d4b1c9f8bfe"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2910), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("796739f3-35f7-41f7-af89-14d1a5dfcb7e"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2917), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3a4ed5d3-8a8a-4a32-8452-94cb2ecdd05e"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2848), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("3ba0691d-c252-49f0-9cf9-abc3b9d95273"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2856), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("46ca04ef-df68-46f0-a218-60d3f2a912c4"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2857), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("7690ff48-78dd-408c-8a6a-7e0d3f7b674b"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2854), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("a5e68865-6f97-4233-bd72-4bb7a83b988b"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2846), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("eea12633-8982-415a-a811-e91f71e8efe8"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2839), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("d3d2bf12-6557-44ff-b6f3-29af32396095"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2887), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1b4a568a-9141-4cdb-b1bc-233046767fd7"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("34519611-79ce-409b-942e-a96ca64b5d97"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("68ab3a93-84ad-4869-8231-affad9912cf1"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("9514455f-ca2d-48dd-bfc2-faa8350410ba"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("a05dfeb9-04be-4a12-a40f-3901917d2beb"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("c9897771-7e4c-48d7-afbf-4d2a86862eca"), "Guest role is the least privileged role. They can only view public articles.", "Guest" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("359b6e4f-f832-45f2-b98c-2fe1784bb3b9"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2984), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("9552ad10-6e3b-440b-a86c-bd5ce8fa84cb"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2992), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("b0fcdb72-a2c7-47e4-8fa9-4a23e3c6e20a"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2986), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("ba20b8b2-2040-4f6e-9592-2f96aa8559dd"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2988), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("ea7ef0bb-ce54-4707-93b4-30c8641605ed"), new DateTime(2025, 1, 30, 0, 7, 48, 786, DateTimeKind.Utc).AddTicks(2981), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" }
                });
        }
    }
}
