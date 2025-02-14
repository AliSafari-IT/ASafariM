using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0e22ddab-717e-42bf-8533-c8221f5302a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("12b41a91-d6cc-4a8b-a263-e7fd36ff37a4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30689c8b-29fd-45e0-99aa-7a93e40b9218"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4f8ed61b-17f0-4a53-a59e-5533bd1ca9ad"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b75fb1c-84d0-4d16-b3f5-e65bc9c23607"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76da300c-537e-4dd5-8aba-d9085bc142d2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96c2c97d-690e-4234-818a-78d58c8cd08f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e5e9851-1a22-4fad-b438-2f01b12510c8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("edfedafd-f09c-4715-a4e4-c89aa513b612"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f94b65af-8e26-4870-8115-80dda4caf41c"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("172d42a2-4f40-4060-9f3d-8fbb49a7f674"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("3af61412-c3a7-426b-bf2b-43775fab8b53"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("636775eb-d830-4d46-a042-1d55b675b342"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("fb1e9bb4-6d0b-407b-9077-c74793c33cac"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("430c3357-4abf-42aa-a395-4f160d9105ae"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("48579b09-f674-41f3-909c-aabff0f21a62"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("5fe0543d-7e70-4a83-9947-2ae5aa8a0e3e"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("e2031a74-33a7-404c-b6af-c95d5b41f331"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("16b949e7-b4a6-4a78-ad49-22082bad122b"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("2529ef8d-6d83-4af1-afe0-4e179f9cad88"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("56daa222-05de-4dac-8c69-0770058dfb39"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("5c3e3197-0d7d-43a7-bf55-f2b88530e3e4"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("e31f149a-385b-4423-9498-a472dd5c38d1"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("fac3f6f8-84e6-4ec2-81bb-8eabe665869e"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("791601e7-db1b-4c47-943f-d39b13442b74"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("132f6378-c3b0-4a4b-ae1e-48758a54d1c4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6097b82f-2f65-4b4a-8365-610f329da128"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("671be8aa-b4ad-4bd8-b6f2-81147194c46e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7777983f-583f-4e81-8b95-9a464d991461"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a5a91b25-1d64-449e-8e8e-c667aa14a7f0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e0232132-93e8-42be-a765-008707d82627"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5e45c6b0-5adb-4d70-a92f-7866a09338fc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("89beac11-2705-48a8-ad88-0f57a44cd400"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8b235b63-017c-4a2a-bcb6-2398dcdb0515"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f098f1a3-8692-4ce9-86f0-92557bfe3329"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("566319c2-4d49-4c7c-bc6a-3aaf3e506a3a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("6b14cab7-7ab8-4ad9-8321-f52646782c0a"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("a28ebd2a-ec51-4776-b42f-124179b7b2af"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("c3b21ece-fe8e-4f06-82b5-68741eaed073"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("efcecd78-a5e8-4c46-9e18-7d8ecad2cbb9"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("4335f708-81f5-4978-9656-297f431dcb53"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("7e97d66c-db54-47f2-a37e-3c54d4f1b96d"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("e67b25cd-6079-4bb6-a9a1-2cd718f118bc"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("01cdd66c-3cb0-4635-a0e3-0e479f9bd83a"), "Vienna", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9358), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("106fecd1-8713-4edc-9266-39eaf930adda"), "London", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9346), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("29ae2dd9-a815-4558-b95d-bf27c5ed463e"), "Rome", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9349), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("682a6c8b-63ff-401f-8862-d67e86c8d8e5"), "Amsterdam", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9337), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("af90a9f9-3ec8-42c4-8525-fad4e1073369"), "Berlin", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9334), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("b1979397-8b89-4ef3-bd25-f842be4eadbc"), "Paris", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9330), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("bafdddc4-1482-4327-a76d-adfc2399eb3c"), "Luxembourg", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9361), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null },
                    { new Guid("d3a5d6ab-640e-442a-8f22-52e09382abb0"), "Madrid", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9352), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("dc7f378d-1bcf-4865-bdc9-3bd55da529df"), "Bern", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(9355), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("f678022d-418f-48d8-b573-6391d5a7932d"), "Brussels", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(8648), true, "BE", "BEL", "Belgium", "België", "+32", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("149e0c27-92ec-4079-9599-5529c806f276"), "EUR", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(1615), 2, true, "Euro", "€", null },
                    { new Guid("86dc1971-03f2-4417-b7f1-1db8ffe2d4a3"), "CHF", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(3197), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("d3f8c08e-e7e3-4994-95a8-88e448ea049f"), "USD", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(3184), 2, true, "US Dollar", "$", null },
                    { new Guid("e075f875-b714-49eb-8336-6414e47a35c0"), "GBP", new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(3194), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("092ccf6f-c7f0-4065-b81f-eb0efecedb19"), new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(428), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("38da7556-3f24-4577-b316-0498e320187d"), new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(449), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("5961143b-b67e-4454-ae39-427deea839dd"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(9055), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("8cb50453-57d6-488b-9487-62687615eaa8"), new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(452), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("04806585-e319-4628-bec3-9c472ed4458f"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(5030), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("06813401-4406-4295-b660-d5f826e90c79"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(5034), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("2446e4ef-fa77-4fed-828c-534fe5060984"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(3001), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("73c253d7-2c02-4b69-b1a5-ee0e27140034"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(5019), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("9dcc80d5-fdda-48e2-9bfe-e008ca54305f"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(5032), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("d9210d78-c533-4609-b244-39d0122f013c"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(5028), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("0b38acd2-1aca-49bd-b886-c7455ae9cda9"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(6302), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("16d12c53-e85c-489f-80e8-4e3de177db60"), new DateTime(2025, 2, 14, 14, 41, 43, 621, DateTimeKind.Utc).AddTicks(8892), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("3fc9cca7-36d0-4441-8fc3-8042f27c293d"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(363), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("b2956a60-03b6-429e-9eca-a47e6f97edac"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(428), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("b9689049-cdde-4ee3-b33f-49ccd3f5180e"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(433), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("e01541fa-03e8-49c2-83ed-a3290f60c2b7"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(347), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null },
                    { new Guid("fe6570d4-f6dc-4e35-add4-bb542d4ab5e2"), new DateTime(2025, 2, 14, 14, 41, 43, 622, DateTimeKind.Utc).AddTicks(431), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("211208e8-b3c7-4a14-a0aa-ce196a455278"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("3d6a3aa5-f9ee-4c53-ae09-fddf00273d6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("59ec0525-d08c-4355-b70e-0160c51206c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("fef3b6df-e619-478b-91e0-298927177cec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("16e25da5-e003-4e98-b68c-3f9865bf7065"), new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(5852), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("287bc75b-845c-4a14-ab1d-a409afcc4883"), new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(5857), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("5b68ea5e-3816-4054-b2fb-e36fc058c77b"), new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(5854), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("b83df421-d9cb-4360-b1aa-ea9e8bc690f0"), new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(4333), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("deb843f8-9ca0-4617-9472-0e6b6ca02763"), new DateTime(2025, 2, 14, 14, 41, 43, 623, DateTimeKind.Utc).AddTicks(5776), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 14, 41, 43, 624, DateTimeKind.Utc).AddTicks(3148));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("022d1415-5d24-45b8-a5e8-45530a3a0bdd"), new DateTime(2025, 2, 14, 14, 41, 43, 624, DateTimeKind.Utc).AddTicks(4336), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("0644c20a-3d4f-4354-8b2e-a527fb8f8790"), new DateTime(2025, 2, 14, 14, 41, 43, 624, DateTimeKind.Utc).AddTicks(4648), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("801b5c27-ebc5-4455-9e2d-170ff1fe6405"), new DateTime(2025, 2, 14, 14, 41, 43, 624, DateTimeKind.Utc).AddTicks(4677), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastLogin", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "demo_user@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 512, DateTimeKind.Utc).AddTicks(6782), "demo_user@example.com", "Demo User", new DateTime(2025, 2, 14, 14, 41, 43, 512, DateTimeKind.Utc).AddTicks(6769), "Account", "DEMO_USER@EXAMPLE.COM", "DEMO_USER", "guflw+RxcT5HpVXJ6Vk2+TqbRmexm5kJpDXFLx9hYLpQDY51Mu62IVVoAxGpgFbN", "demo_user@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 512, DateTimeKind.Utc).AddTicks(6873), "demo_user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_6798@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 537, DateTimeKind.Utc).AddTicks(6245), "user_1_6798@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 537, DateTimeKind.Utc).AddTicks(6241), "USER_1_6798@EXAMPLE.COM", "USER_1_6798", "KGa5ZIvrOROqHuak9lESEV3pHHYCQwBww7Le6xJDFp/1nQiHDKwVoFqY26gtak33", "user_1_6798@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 537, DateTimeKind.Utc).AddTicks(6247), "user_1_6798" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_115c@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 547, DateTimeKind.Utc).AddTicks(7958), "user_2_115c@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 547, DateTimeKind.Utc).AddTicks(7952), "USER_2_115C@EXAMPLE.COM", "USER_2_115C", "yRdf0bfEwzo5eenurlWp6PZ20BgB1hx7uExohWCpRqcr8U4wSJ/r69dpKcohgCl6", "user_2_115c@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 547, DateTimeKind.Utc).AddTicks(7967), "user_2_115c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_b2d4@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 557, DateTimeKind.Utc).AddTicks(582), "user_3_b2d4@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 557, DateTimeKind.Utc).AddTicks(577), "USER_3_B2D4@EXAMPLE.COM", "USER_3_B2D4", "Cuh75P7lUUiQ7SVBAo4tKKu/fostNeTeAo3nyRjXGlBzpRtuemV8COkuC5fgCNpy", "user_3_b2d4@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 557, DateTimeKind.Utc).AddTicks(584), "user_3_b2d4" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_3ad1@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 566, DateTimeKind.Utc).AddTicks(6747), "user_4_3ad1@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 566, DateTimeKind.Utc).AddTicks(6741), "USER_4_3AD1@EXAMPLE.COM", "USER_4_3AD1", "DqhPBL81CUxwYwQKe8XAbfKzDvuX718vhrtkSVXxsz9y3O7jtWjunAgBzoEr264s", "user_4_3ad1@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 566, DateTimeKind.Utc).AddTicks(6752), "user_4_3ad1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_3341@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 575, DateTimeKind.Utc).AddTicks(2744), "user_5_3341@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 575, DateTimeKind.Utc).AddTicks(2741), "USER_5_3341@EXAMPLE.COM", "USER_5_3341", "s3NXRCN1v9W3KenlTAvF8rxcWrSH+XTV0HBTyAdYZaYkEe4iNOWt1ULR+iWxC34e", "user_5_3341@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 575, DateTimeKind.Utc).AddTicks(2746), "user_5_3341" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_1465@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 585, DateTimeKind.Utc).AddTicks(8917), "user_6_1465@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 585, DateTimeKind.Utc).AddTicks(8911), "USER_6_1465@EXAMPLE.COM", "USER_6_1465", "utLGnAcLVZXRQFyDnksZsb7QsdgiAog1k+6zqvQb3HUma2eYd1r3gVwzf9SpXktn", "user_6_1465@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 585, DateTimeKind.Utc).AddTicks(8919), "user_6_1465" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_4f68@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 596, DateTimeKind.Utc).AddTicks(5218), "user_7_4f68@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 596, DateTimeKind.Utc).AddTicks(5214), "USER_7_4F68@EXAMPLE.COM", "USER_7_4F68", "hpXGWI5CfvWTWGK2WgsmluuK2AnAW9o83xYEHYT2lynUs9OQxZIof/TBodQ5uuCb", "user_7_4f68@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 596, DateTimeKind.Utc).AddTicks(5218), "user_7_4f68" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_9896@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 604, DateTimeKind.Utc).AddTicks(7163), "user_8_9896@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 604, DateTimeKind.Utc).AddTicks(7160), "USER_8_9896@EXAMPLE.COM", "USER_8_9896", "5v4I+ILKGcpYwsYGCtJuuYJI9uwtp0UdxDeNcqjyGoVnfFAAgxqULKZ3uv/ATi8Y", "user_8_9896@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 604, DateTimeKind.Utc).AddTicks(7164), "user_8_9896" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_556d@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 611, DateTimeKind.Utc).AddTicks(7916), "user_9_556d@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 611, DateTimeKind.Utc).AddTicks(7913), "USER_9_556D@EXAMPLE.COM", "USER_9_556D", "lCd1K0zuZB4AoDhySoJTf/uK0yt+e43EVWlmKrehRW8qn0RZKpBWj1MQnQ1eK/ZC", "user_9_556d@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 611, DateTimeKind.Utc).AddTicks(7917), "user_9_556d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_33ec@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 621, DateTimeKind.Utc).AddTicks(3905), "user_10_33ec@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 621, DateTimeKind.Utc).AddTicks(3902), "USER_10_33EC@EXAMPLE.COM", "USER_10_33EC", "QbqgYoYFJLYMo4JhZDn9L1vo99S2y1h0fE9jiu1yzp91g80Rsn5wwo0IHnz9dXNo", "user_10_33ec@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 621, DateTimeKind.Utc).AddTicks(3908), "user_10_33ec" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastLogin", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "demo_admin@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 505, DateTimeKind.Utc).AddTicks(312), "demo_admin@example.com", "Demo Admin", new DateTime(2025, 2, 14, 14, 41, 43, 504, DateTimeKind.Utc).AddTicks(7073), "Account", "DEMO_ADMIN@EXAMPLE.COM", "DEMO_ADMIN", "yZ/FwbXp9fWMfGHKwrLVczvPDn7TvG+eb3303HMGWMUvI76W6BLDSlNIrwJp/g82", "demo_admin@example.com", new DateTime(2025, 2, 14, 14, 41, 43, 505, DateTimeKind.Utc).AddTicks(1081), "demo_admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01cdd66c-3cb0-4635-a0e3-0e479f9bd83a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("106fecd1-8713-4edc-9266-39eaf930adda"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29ae2dd9-a815-4558-b95d-bf27c5ed463e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("682a6c8b-63ff-401f-8862-d67e86c8d8e5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("af90a9f9-3ec8-42c4-8525-fad4e1073369"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1979397-8b89-4ef3-bd25-f842be4eadbc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bafdddc4-1482-4327-a76d-adfc2399eb3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d3a5d6ab-640e-442a-8f22-52e09382abb0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dc7f378d-1bcf-4865-bdc9-3bd55da529df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f678022d-418f-48d8-b573-6391d5a7932d"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("149e0c27-92ec-4079-9599-5529c806f276"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("86dc1971-03f2-4417-b7f1-1db8ffe2d4a3"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("d3f8c08e-e7e3-4994-95a8-88e448ea049f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("e075f875-b714-49eb-8336-6414e47a35c0"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("092ccf6f-c7f0-4065-b81f-eb0efecedb19"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("38da7556-3f24-4577-b316-0498e320187d"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("5961143b-b67e-4454-ae39-427deea839dd"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("8cb50453-57d6-488b-9487-62687615eaa8"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("04806585-e319-4628-bec3-9c472ed4458f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("06813401-4406-4295-b660-d5f826e90c79"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("2446e4ef-fa77-4fed-828c-534fe5060984"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("73c253d7-2c02-4b69-b1a5-ee0e27140034"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("9dcc80d5-fdda-48e2-9bfe-e008ca54305f"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d9210d78-c533-4609-b244-39d0122f013c"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("0b38acd2-1aca-49bd-b886-c7455ae9cda9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("16d12c53-e85c-489f-80e8-4e3de177db60"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3fc9cca7-36d0-4441-8fc3-8042f27c293d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b2956a60-03b6-429e-9eca-a47e6f97edac"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b9689049-cdde-4ee3-b33f-49ccd3f5180e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e01541fa-03e8-49c2-83ed-a3290f60c2b7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fe6570d4-f6dc-4e35-add4-bb542d4ab5e2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("211208e8-b3c7-4a14-a0aa-ce196a455278"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3d6a3aa5-f9ee-4c53-ae09-fddf00273d6f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("59ec0525-d08c-4355-b70e-0160c51206c3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fef3b6df-e619-478b-91e0-298927177cec"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("16e25da5-e003-4e98-b68c-3f9865bf7065"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("287bc75b-845c-4a14-ab1d-a409afcc4883"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("5b68ea5e-3816-4054-b2fb-e36fc058c77b"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("b83df421-d9cb-4360-b1aa-ea9e8bc690f0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("deb843f8-9ca0-4617-9472-0e6b6ca02763"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("022d1415-5d24-45b8-a5e8-45530a3a0bdd"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("0644c20a-3d4f-4354-8b2e-a527fb8f8790"));

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("801b5c27-ebc5-4455-9e2d-170ff1fe6405"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0e22ddab-717e-42bf-8533-c8221f5302a3"), "Berlin", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2291), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("12b41a91-d6cc-4a8b-a263-e7fd36ff37a4"), "Rome", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2378), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("30689c8b-29fd-45e0-99aa-7a93e40b9218"), "Paris", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2281), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("4f8ed61b-17f0-4a53-a59e-5533bd1ca9ad"), "Bern", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2384), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("6b75fb1c-84d0-4d16-b3f5-e65bc9c23607"), "Amsterdam", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2371), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("76da300c-537e-4dd5-8aba-d9085bc142d2"), "Vienna", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2387), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("96c2c97d-690e-4234-818a-78d58c8cd08f"), "Brussels", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(1573), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("9e5e9851-1a22-4fad-b438-2f01b12510c8"), "London", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2375), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("edfedafd-f09c-4715-a4e4-c89aa513b612"), "Madrid", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2381), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("f94b65af-8e26-4870-8115-80dda4caf41c"), "Luxembourg", new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(2390), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("172d42a2-4f40-4060-9f3d-8fbb49a7f674"), "USD", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6352), 2, true, "US Dollar", "$", null },
                    { new Guid("3af61412-c3a7-426b-bf2b-43775fab8b53"), "EUR", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(5259), 2, true, "Euro", "€", null },
                    { new Guid("636775eb-d830-4d46-a042-1d55b675b342"), "CHF", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6360), 2, true, "Swiss Franc", "Fr.", null },
                    { new Guid("fb1e9bb4-6d0b-407b-9077-c74793c33cac"), "GBP", new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(6358), 2, true, "British Pound", "£", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("430c3357-4abf-42aa-a395-4f160d9105ae"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4215), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null },
                    { new Guid("48579b09-f674-41f3-909c-aabff0f21a62"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(2726), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("5fe0543d-7e70-4a83-9947-2ae5aa8a0e3e"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4223), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("e2031a74-33a7-404c-b6af-c95d5b41f331"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(4225), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16b949e7-b4a6-4a78-ad49-22082bad122b"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8519), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("2529ef8d-6d83-4af1-afe0-4e179f9cad88"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8514), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("56daa222-05de-4dac-8c69-0770058dfb39"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8507), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("5c3e3197-0d7d-43a7-bf55-f2b88530e3e4"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8517), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("e31f149a-385b-4423-9498-a472dd5c38d1"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(7109), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null },
                    { new Guid("fac3f6f8-84e6-4ec2-81bb-8eabe665869e"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(8522), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("791601e7-db1b-4c47-943f-d39b13442b74"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(9500), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("132f6378-c3b0-4a4b-ae1e-48758a54d1c4"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5832), new Guid("00000000-0000-0000-0000-000000000000"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor", null, null },
                    { new Guid("6097b82f-2f65-4b4a-8365-610f329da128"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5829), new Guid("00000000-0000-0000-0000-000000000000"), "Guest role is the least privileged role. They can only view public articles.", "Guest", null, null },
                    { new Guid("671be8aa-b4ad-4bd8-b6f2-81147194c46e"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5845), new Guid("00000000-0000-0000-0000-000000000000"), "Has full control over the application and can manage all aspects.", "SuperAdmin", null, null },
                    { new Guid("7777983f-583f-4e81-8b95-9a464d991461"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(4725), new Guid("00000000-0000-0000-0000-000000000000"), "Admin role has full administrative privileges, except for application management.", "Admin", null, null },
                    { new Guid("a5a91b25-1d64-449e-8e8e-c667aa14a7f0"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5827), new Guid("00000000-0000-0000-0000-000000000000"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User", null, null },
                    { new Guid("e0232132-93e8-42be-a765-008707d82627"), new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(5820), new Guid("00000000-0000-0000-0000-000000000000"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator", null, null }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("5e45c6b0-5adb-4d70-a92f-7866a09338fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 3", "Test Tag name 3", "test-tag-slug-3", null },
                    { new Guid("89beac11-2705-48a8-ad88-0f57a44cd400"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description", "Test Tag name", "test-tag-slug", null },
                    { new Guid("8b235b63-017c-4a2a-bcb6-2398dcdb0515"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 4", "Test Tag name 4", "test-tag-slug-4", null },
                    { new Guid("f098f1a3-8692-4ce9-86f0-92557bfe3329"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test Tag description 2", "Test Tag name 2", "test-tag-slug-2", null }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("566319c2-4d49-4c7c-bc6a-3aaf3e506a3a"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8560), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("6b14cab7-7ab8-4ad9-8321-f52646782c0a"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8558), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("a28ebd2a-ec51-4776-b42f-124179b7b2af"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8588), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("c3b21ece-fe8e-4f06-82b5-68741eaed073"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(7256), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("efcecd78-a5e8-4c46-9e18-7d8ecad2cbb9"), new DateTime(2025, 2, 14, 14, 15, 7, 488, DateTimeKind.Utc).AddTicks(8551), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                column: "CreatedAt",
                value: new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "ParentTopicId", "Slug", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4335f708-81f5-4978-9656-297f431dcb53"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7702), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3", null, null },
                    { new Guid("7e97d66c-db54-47f2-a37e-3c54d4f1b96d"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7402), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2", null, null },
                    { new Guid("e67b25cd-6079-4bb6-a9a1-2cd718f118bc"), new DateTime(2025, 2, 14, 14, 15, 7, 489, DateTimeKind.Utc).AddTicks(7709), new Guid("00000000-0000-0000-0000-000000000000"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1048da39-cdaf-47a9-9fb1-960d81dd704b"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastLogin", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4223), "user@example.com", "User", new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4209), "Example", "USER@EXAMPLE.COM", "USER", "21O0ZZzxUly48wQU1wbHwpkiDgGnUaBVIsYDDw50zTQLRGEgkjnrIdkyoRaGxS2R", "user@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 387, DateTimeKind.Utc).AddTicks(4224), "user" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb5"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_1_27ac@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4028), "user_1_27ac@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4023), "USER_1_27AC@EXAMPLE.COM", "USER_1_27AC", "TPYvYMTD2MT0HF2rtf8Dg1DYO6bbEea56ZK+UxfUh2J2rxsT5syDLHuscaadOLNZ", "user_1_27ac@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 416, DateTimeKind.Utc).AddTicks(4030), "user_1_27ac" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb6"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_2_0e2b@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5581), "user_2_0e2b@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5578), "USER_2_0E2B@EXAMPLE.COM", "USER_2_0E2B", "+QmUyNzGT/ENRiVHBAr3vp0flurbbVNsH9dya+8xB50yWMj6L5Hryy+RXScPbWGr", "user_2_0e2b@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 423, DateTimeKind.Utc).AddTicks(5582), "user_2_0e2b" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb7"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_3_05e6@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3415), "user_3_05e6@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3410), "USER_3_05E6@EXAMPLE.COM", "USER_3_05E6", "xFK5BIiuQsLAw+kkNrxtDMzGvkJHaIWvp4MM+sFOPgL4i/xQawPMQ56IEieTKveo", "user_3_05e6@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 431, DateTimeKind.Utc).AddTicks(3417), "user_3_05e6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb8"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_4_8b11@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9863), "user_4_8b11@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9859), "USER_4_8B11@EXAMPLE.COM", "USER_4_8B11", "CF+Ud3s3kIpjf7JWp4BwFHtL0Ys1VeJ0B+We7M7n8htUvEBysazMcg6quUOZkXgQ", "user_4_8b11@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 438, DateTimeKind.Utc).AddTicks(9864), "user_4_8b11" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fb9"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_5_b7b7@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8074), "user_5_b7b7@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8070), "USER_5_B7B7@EXAMPLE.COM", "USER_5_B7B7", "Isd4uFid1hiCX8F5rYwsxiNSi1C4LWPzpCqgNcHnRmaRu96KIkJlKcI7zx75hKJD", "user_5_b7b7@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 446, DateTimeKind.Utc).AddTicks(8076), "user_5_b7b7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fba"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_6_b911@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1285), "user_6_b911@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1281), "USER_6_B911@EXAMPLE.COM", "USER_6_B911", "y4jzrUyYijyNQQ6IGo+PZWtBRe+p+40gejUj0dRh/rSfo1xlLoPwnZy80Erlf7iT", "user_6_b911@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 454, DateTimeKind.Utc).AddTicks(1287), "user_6_b911" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbb"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_7_672d@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4797), "user_7_672d@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4793), "USER_7_672D@EXAMPLE.COM", "USER_7_672D", "bezFTDkcW/tWp0+JHlNzFpCtsSoCGt50ZTP/yk6yLMuJSJPRiVtA1j2Ovh+WVgDR", "user_7_672d@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 461, DateTimeKind.Utc).AddTicks(4799), "user_7_672d" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbc"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_8_be02@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8079), "user_8_be02@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8076), "USER_8_BE02@EXAMPLE.COM", "USER_8_BE02", "j4J5a0kvbRCkpSMuRyOfEWaMjMk5lCIRbixteCVEUCIjIhvssNfmtxZW0EPfcCsG", "user_8_be02@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 469, DateTimeKind.Utc).AddTicks(8081), "user_8_be02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbd"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_9_3b00@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3350), "user_9_3b00@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3345), "USER_9_3B00@EXAMPLE.COM", "USER_9_3B00", "/oGrAHb5BryniXLN1fYE0v9XMOtgYPqbaco3gUnAiJKhifEWJssD68Fnb9FabHlA", "user_9_3b00@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 478, DateTimeKind.Utc).AddTicks(3352), "user_9_3b00" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fb725c6-3250-b856-604e-69f27e228fbe"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "LastLogin", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "user_10_7f38@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1704), "user_10_7f38@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1695), "USER_10_7F38@EXAMPLE.COM", "USER_10_7F38", "5kON/sirrfwYdjLGgPy5S6w3tdQBQKgPzEQjn6XL2jmQRrWzXR8Nva8EIVFB7t3R", "user_10_7f38@example.com", new DateTime(2025, 2, 14, 14, 15, 7, 487, DateTimeKind.Utc).AddTicks(1711), "user_10_7f38" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8048da39-cdaf-47a9-9fb1-960d81dd704a"),
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "Email", "FirstName", "LastLogin", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UpdatedAt", "UserName" },
                values: new object[] { "ali@asafarim.com", new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(7283), "ali@asafarim.com", "Ali R.", new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(2142), "Safari", "ALI@ASAFARIM.COM", "ALI", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", "ali@asafarim.com", new DateTime(2025, 2, 14, 14, 15, 7, 368, DateTimeKind.Utc).AddTicks(8804), "ali" });
        }
    }
}
