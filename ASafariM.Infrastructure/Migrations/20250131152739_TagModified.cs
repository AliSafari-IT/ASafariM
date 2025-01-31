using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TagModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("17c5bebd-4ba9-48ea-be06-9e183a5ea4e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18c0299c-d743-48af-936b-256dd3c150c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("636874da-9ef0-43c2-ade5-882c58a5b610"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("69045b5e-b7ba-4195-988c-da6a69771a72"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("871f1bbe-05a0-415a-9ce5-f4f401dc0232"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b89b965b-b841-4dd0-a7a6-15b7cbb1461c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf039124-1b85-40e2-9c92-ac6818eae77d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cdacedf7-f976-413b-bc9c-6174cd6acb13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc32ac10-2f47-4159-adcf-208cba610642"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f0a91fbc-f95a-4ac7-91e9-df9ec33cc41c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("15c89762-7d4b-444c-8639-07e31c560cf4"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("dade6f17-23df-4717-bd83-c18e25f141a3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("efef39f1-6976-4158-9457-e25e74278108"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("f5b9cab3-e6ab-4bb0-8338-51fad8270c14"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0edafad8-8ca3-49ba-801e-38d5c670f29f"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("63b1e3c6-a3aa-4c75-bcd8-5b43ec440cdd"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("84dbc2ab-d979-4d93-a82b-a34ed2986455"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("f89eee52-7cce-4fbe-916e-d87c871b46d3"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("364ac633-a685-4827-b000-b5f53eb963b7"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c6437072-6724-48e3-911f-3b316a3a1d6d"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("c92031c7-ca64-4fbe-aa4b-4dce49376549"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d6f30d3a-e33f-4ce0-aa5f-caf5a16decc1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("da0d600f-799e-42ee-8919-bfb441b12f2c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fc2f5490-dfdd-4125-9c86-2a7cfe5bb732"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("9696956c-2df5-4db6-b89d-c9a51d86aa61"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("063aaff6-e8a8-4df5-a353-4a27ce6d7428"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68a2522e-da57-47ac-b39f-bf0a4331f073"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6dfa4233-447d-483d-b193-76c0311b1a3e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("abe5df4f-3edd-4e6f-b8f6-b4b270a3b779"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b9dfecda-7809-4e31-a275-1aaad76ef0eb"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fd3f1680-70b9-4ef6-baaa-163083de192d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("060efec7-587d-4288-b1b8-13515bd10cc9"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("3eff4581-d443-4b64-85be-63bd45a4b117"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("80e5531a-449d-4b71-a86a-cfeb18b51b3d"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("9d36d73d-584f-4661-b0b8-6dcc303deea0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("dd777968-7e03-4626-8f70-39708e0e7fa0"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2c045b97-f553-4357-a32c-43c0645edb5a"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5628), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("369c7ee0-c6bd-4dca-b757-17a34c7dd8a3"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5642), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("40ede959-230c-4150-8fc5-99e435b63a8b"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5651), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("71cfe817-03fa-423e-9e78-e0ffc2dc34b4"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5648), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("71d76a19-658d-40db-8b80-ea7d71531c15"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5660), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("742340ca-3524-4d81-98e2-af1305709a24"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5631), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("83aa6e6a-9446-4e62-9e0e-497b6e9242e4"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5625), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("97b10a3b-322b-4973-b457-99ffce22f937"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5610), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("982f5da4-8d7f-4305-9f2f-9fc134cb4b47"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5653), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("efbed95e-b296-4f2c-abe1-8ab179d311d1"), "Brussels", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5645), true, "IT", "ITA", "Italy", "Italia", "+39", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2792f4f5-a0f6-4899-ab37-19c74e4d2ad3"), "GBP", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5509), 2, true, "British Pound", "£", null },
                    { new Guid("46f2144b-1597-4547-8343-2d61252a5175"), "USD", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5506), 2, true, "US Dollar", "$", null },
                    { new Guid("78adc1a4-bf6c-4b6b-ad99-6664f9f42e62"), "EUR", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5502), 2, true, "Euro", "€", null },
                    { new Guid("d8c190ec-9cc0-47d9-8510-53514ea93d03"), "CHF", new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5511), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0dcaa339-706b-4a1d-8a23-71ef6bdf4eec"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5446), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("6c39a3bb-5e5d-48f0-958d-f75948307799"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5448), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("958859f8-8c50-4cdb-ad36-a9f323388fbb"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5443), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("d034e14f-d0f5-40ed-9ebd-ca2beca14adb"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5434), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0dd5d9f2-8742-413f-a798-403ae6e97729"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5307), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("36d61fa4-34bf-46f7-98d5-bf22f0e55f92"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5304), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("3735fe4e-e789-42a9-9fd7-72a4593a64aa"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5301), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("95f11c15-f0ef-40ad-9992-9f3b0638f282"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5298), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("a2a75136-ec5f-407b-84f7-7d5de1d35688"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5285), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("fe54e10a-35ca-4040-8c30-42102ce6e029"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5294), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("705b6cfe-4285-459e-8caf-f9ea293bb663"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5369), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("5aaa66f5-ea3a-4e39-8879-15877d4b1e0f"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("640ba588-1902-4e34-b912-b1da97ac82d8"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("67722467-ba26-4968-9225-bb24bec936ca"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("9e715b2a-f845-4502-a348-d12a3ef1d5d4"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("bcea53d6-3ef8-4c81-beb4-8a7bdb30758e"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("fe5f17b2-19c3-4fe5-934b-1f73d8d7ce88"), "Guest role is the least privileged role. They can only view public articles.", "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Description", "Name", "PostId", "Slug" },
                values: new object[] { new Guid("f0536545-04b7-4e3c-9190-5176e0222085"), "Test Tag description", "Test Tag name", null, "test-tag-slug" });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("40834324-6126-46df-b116-8ecda51a2754"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5570), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("6c3f1fb6-7daf-40a7-816c-263ad23e3024"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5554), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("7ab0eb9c-c8d4-42d7-bc0b-b4a942d2f9c0"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5567), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("85cdad0a-e3ed-4436-a832-7dc2a818832c"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5561), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" },
                    { new Guid("aa66e3e3-0881-447a-b81e-620b3050e429"), new DateTime(2025, 1, 31, 15, 27, 38, 967, DateTimeKind.Utc).AddTicks(5565), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2c045b97-f553-4357-a32c-43c0645edb5a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("369c7ee0-c6bd-4dca-b757-17a34c7dd8a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("40ede959-230c-4150-8fc5-99e435b63a8b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71cfe817-03fa-423e-9e78-e0ffc2dc34b4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("71d76a19-658d-40db-8b80-ea7d71531c15"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("742340ca-3524-4d81-98e2-af1305709a24"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("83aa6e6a-9446-4e62-9e0e-497b6e9242e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("97b10a3b-322b-4973-b457-99ffce22f937"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("982f5da4-8d7f-4305-9f2f-9fc134cb4b47"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("efbed95e-b296-4f2c-abe1-8ab179d311d1"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("2792f4f5-a0f6-4899-ab37-19c74e4d2ad3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("46f2144b-1597-4547-8343-2d61252a5175"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("78adc1a4-bf6c-4b6b-ad99-6664f9f42e62"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d8c190ec-9cc0-47d9-8510-53514ea93d03"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("0dcaa339-706b-4a1d-8a23-71ef6bdf4eec"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("6c39a3bb-5e5d-48f0-958d-f75948307799"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("958859f8-8c50-4cdb-ad36-a9f323388fbb"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("d034e14f-d0f5-40ed-9ebd-ca2beca14adb"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("0dd5d9f2-8742-413f-a798-403ae6e97729"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("36d61fa4-34bf-46f7-98d5-bf22f0e55f92"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3735fe4e-e789-42a9-9fd7-72a4593a64aa"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("95f11c15-f0ef-40ad-9992-9f3b0638f282"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a2a75136-ec5f-407b-84f7-7d5de1d35688"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fe54e10a-35ca-4040-8c30-42102ce6e029"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("705b6cfe-4285-459e-8caf-f9ea293bb663"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5aaa66f5-ea3a-4e39-8879-15877d4b1e0f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("640ba588-1902-4e34-b912-b1da97ac82d8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("67722467-ba26-4968-9225-bb24bec936ca"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9e715b2a-f845-4502-a348-d12a3ef1d5d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bcea53d6-3ef8-4c81-beb4-8a7bdb30758e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fe5f17b2-19c3-4fe5-934b-1f73d8d7ce88"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f0536545-04b7-4e3c-9190-5176e0222085"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("40834324-6126-46df-b116-8ecda51a2754"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6c3f1fb6-7daf-40a7-816c-263ad23e3024"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("7ab0eb9c-c8d4-42d7-bc0b-b4a942d2f9c0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("85cdad0a-e3ed-4436-a832-7dc2a818832c"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("aa66e3e3-0881-447a-b81e-620b3050e429"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("17c5bebd-4ba9-48ea-be06-9e183a5ea4e8"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5714), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("18c0299c-d743-48af-936b-256dd3c150c3"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5708), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("636874da-9ef0-43c2-ade5-882c58a5b610"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5722), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("69045b5e-b7ba-4195-988c-da6a69771a72"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5720), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("871f1bbe-05a0-415a-9ce5-f4f401dc0232"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5701), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("b89b965b-b841-4dd0-a7a6-15b7cbb1461c"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5696), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("bf039124-1b85-40e2-9c92-ac6818eae77d"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5716), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("cdacedf7-f976-413b-bc9c-6174cd6acb13"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5706), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("dc32ac10-2f47-4159-adcf-208cba610642"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5718), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("f0a91fbc-f95a-4ac7-91e9-df9ec33cc41c"), "Brussels", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5728), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("15c89762-7d4b-444c-8639-07e31c560cf4"), "GBP", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5588), 2, true, "British Pound", "£", null },
                    { new Guid("dade6f17-23df-4717-bd83-c18e25f141a3"), "USD", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5586), 2, true, "US Dollar", "$", null },
                    { new Guid("efef39f1-6976-4158-9457-e25e74278108"), "EUR", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5582), 2, true, "Euro", "€", null },
                    { new Guid("f5b9cab3-e6ab-4bb0-8338-51fad8270c14"), "CHF", new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5593), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0edafad8-8ca3-49ba-801e-38d5c670f29f"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5536), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("63b1e3c6-a3aa-4c75-bcd8-5b43ec440cdd"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5538), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("84dbc2ab-d979-4d93-a82b-a34ed2986455"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5532), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("f89eee52-7cce-4fbe-916e-d87c871b46d3"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5541), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("364ac633-a685-4827-b000-b5f53eb963b7"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5451), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("c6437072-6724-48e3-911f-3b316a3a1d6d"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5456), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("c92031c7-ca64-4fbe-aa4b-4dce49376549"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5454), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("d6f30d3a-e33f-4ce0-aa5f-caf5a16decc1"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5445), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("da0d600f-799e-42ee-8919-bfb441b12f2c"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5460), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("fc2f5490-dfdd-4125-9c86-2a7cfe5bb732"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5458), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("9696956c-2df5-4db6-b89d-c9a51d86aa61"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5501), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("063aaff6-e8a8-4df5-a353-4a27ce6d7428"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("68a2522e-da57-47ac-b39f-bf0a4331f073"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("6dfa4233-447d-483d-b193-76c0311b1a3e"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("abe5df4f-3edd-4e6f-b8f6-b4b270a3b779"), "Admin role has full administrative privileges, except for application management.", "Admin" },
                    { new Guid("b9dfecda-7809-4e31-a275-1aaad76ef0eb"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("fd3f1680-70b9-4ef6-baaa-163083de192d"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("060efec7-587d-4288-b1b8-13515bd10cc9"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5661), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("3eff4581-d443-4b64-85be-63bd45a4b117"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5663), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("80e5531a-449d-4b71-a86a-cfeb18b51b3d"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5643), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("9d36d73d-584f-4661-b0b8-6dcc303deea0"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5659), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("dd777968-7e03-4626-8f70-39708e0e7fa0"), new DateTime(2025, 1, 31, 15, 22, 16, 593, DateTimeKind.Utc).AddTicks(5656), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });
        }
    }
}
