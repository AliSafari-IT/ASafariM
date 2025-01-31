using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TagSimplified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts");

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

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PostTags");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PostTags");

            migrationBuilder.DropColumn(
                name: "MetaDescription",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "DifficultyLevel",
                table: "Posts",
                newName: "Status");

            migrationBuilder.AddColumn<Guid>(
                name: "PostId",
                table: "Users",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "PostId1",
                table: "Users",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "UpdatedBy",
                table: "Topics",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Topics",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Topics",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topics",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Topics",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "DeletedBy",
                table: "Topics",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Topics",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Tags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tags",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "PostId",
                table: "Tags",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<Guid>(
                name: "TopicId",
                table: "Posts",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Posts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Posts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Posts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Excerpt",
                table: "Posts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Posts",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "AudioUrl",
                table: "Posts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CommentCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeletedMessage",
                table: "Posts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsDraft",
                table: "Posts",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "PostId",
                table: "Posts",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<string>(
                name: "StatusColor",
                table: "Posts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StatusIcon",
                table: "Posts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StatusMessage",
                table: "Posts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "StatusTooltip",
                table: "Posts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Posts",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Capital",
                table: "Countries",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FileName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Size = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachment_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Text = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Url = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Link_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_PostId",
                table: "Users",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PostId1",
                table: "Users",
                column: "PostId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_PostId",
                table: "Tags",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostId",
                table: "Posts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_PostId",
                table: "Attachment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_PostId",
                table: "Category",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_PostId",
                table: "Link",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Posts_PostId",
                table: "Posts",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Posts_PostId",
                table: "Tags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Posts_PostId",
                table: "Users",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Posts_PostId1",
                table: "Users",
                column: "PostId1",
                principalTable: "Posts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Posts_PostId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Posts_PostId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Posts_PostId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Posts_PostId1",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropIndex(
                name: "IX_Users_PostId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PostId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tags_PostId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostId",
                table: "Posts");

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

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PostId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "AudioUrl",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CommentCount",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "DeletedMessage",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "IsDraft",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "StatusColor",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "StatusIcon",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "StatusMessage",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "StatusTooltip",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Capital",
                table: "Countries");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Posts",
                newName: "DifficultyLevel");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "UpdatedBy",
                keyValue: null,
                column: "UpdatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Topics",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Topics",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Slug",
                keyValue: null,
                column: "Slug",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Topics",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topics",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Topics",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "DeletedBy",
                table: "Topics",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "CreatedBy",
                keyValue: null,
                column: "CreatedBy",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Topics",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Topics",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Slug",
                keyValue: null,
                column: "Slug",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Tags",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tags",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tags",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Tags",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Tags",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Tags",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Tags",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Tags",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tags",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tags",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Tags",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PostTags",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PostTags",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TopicId",
                table: "Posts",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Title",
                keyValue: null,
                column: "Title",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Posts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Summary",
                keyValue: null,
                column: "Summary",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                table: "Posts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Slug",
                keyValue: null,
                column: "Slug",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Posts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "ImageUrl",
                keyValue: null,
                column: "ImageUrl",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Posts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Excerpt",
                keyValue: null,
                column: "Excerpt",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Excerpt",
                table: "Posts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Content",
                keyValue: null,
                column: "Content",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Posts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Author",
                keyValue: null,
                column: "Author",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Posts",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MetaDescription",
                table: "Posts",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
