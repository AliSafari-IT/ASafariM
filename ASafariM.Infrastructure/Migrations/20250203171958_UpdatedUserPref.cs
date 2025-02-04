using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUserPref : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "UserPreferences",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_UserId1",
                table: "UserPreferences",
                column: "UserId1",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreferences_Users_UserId1",
                table: "UserPreferences",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPreferences_Users_UserId1",
                table: "UserPreferences");

            migrationBuilder.DropIndex(
                name: "IX_UserPreferences_UserId1",
                table: "UserPreferences");

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

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserPreferences");

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
                    { new Guid("609374af-26da-4732-a32a-eb0c13e07085"), "Test Topic description 2", "Test Topic name 2", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-2" },
                    { new Guid("7d2edb5e-b8ad-46a2-9a86-bac4462e1a65"), "Test Topic description 3", "Test Topic name 3", null, "test-topic-slug-3" },
                    { new Guid("a62e1eea-47b5-4d5a-922f-c2ab4919ee9d"), "Test Topic description 4", "Test Topic name 4", new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "test-topic-slug-4" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Biography", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DateOfBirth", "DeletedAt", "DeletedBy", "Email", "EmailConfirmed", "FailedLoginAttempts", "FirstName", "IsActive", "IsAdmin", "IsDeleted", "IsLockedOut", "LastLogin", "LastName", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PenName", "PhoneNumber", "PhoneNumberConfirmed", "PostId", "PostId1", "ProfilePicture", "Remark", "SecurityStamp", "UpdatedAt", "UpdatedBy", "UserId", "UserName", "Website" },
                values: new object[] { new Guid("375a3094-2d52-434f-a618-066f927846e4"), null, "ali@asafarim.com", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7269), new Guid("ae243ba2-96e9-4ad0-9362-1ef85119e023"), new DateTime(1975, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ali@asafarim.com", false, 0, "Ali", true, true, false, false, new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7257), "Safari", null, "", "ali@asafarim.com", "m7ihFmnrEpIIJEgVEX+SM7YxcMXf0hbpciQjhE53ZplNJQw8CT/JufmeUV+AQk3G", null, null, false, null, null, "https://example.com/profile.jpg", null, "ali@asafarim.com", new DateTime(2025, 2, 1, 22, 23, 57, 617, DateTimeKind.Utc).AddTicks(7271), new Guid("1ebcd7af-259f-4eac-87e4-9210898386f3"), null, null, null });
        }
    }
}
