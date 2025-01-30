using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASafariM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureSitemapItemRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1b7856de-235e-4669-b343-5ddfbc0eeeef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3321a811-4ef8-4e01-a3f1-76f327a8bdc5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("55e7dd8f-0b49-442f-80a2-1c34c05e6b9c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("89fc43c9-0ff6-45d9-b523-943d0f286b1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b880caf-9bd4-4b1e-b0ff-185b67795588"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8e54a7ed-fc5d-45e1-b2da-dac3dfb3e12e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d060a2c4-18df-4c2a-b12f-b9472d993f42"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f48ec768-9bf2-445a-bbc7-bcf424868923"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f659063e-1620-4e90-98f0-fa20beb2528c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fb24e2cf-4940-4c6e-a7fb-ebd23ff22700"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("2e41d2de-2495-496f-bde1-f82aaaa0d8ce"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("65c70f44-0fab-442c-b4c3-3a8fccdeca3f"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("7672ca09-d81c-4db7-b154-8c48ce58e1ce"));

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: new Guid("c4caabe2-ee97-4b09-aafa-7955132648a6"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("025b7e8d-4b32-4811-b318-89477e0f1fd5"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("532ead27-9bf3-4dbe-9b7b-2e3435c205d0"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("94e9295e-07bb-4c07-a336-5cb76237e7ad"));

            migrationBuilder.DeleteData(
                table: "DateFormats",
                keyColumn: "Id",
                keyValue: new Guid("b5a9b039-b530-4586-852a-f99ec742ddd2"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("16d61393-81e2-4e46-a1cd-97a56a1219b5"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("3c30fd5e-e7ef-41a3-af62-9effb3883f94"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("46566d1f-826e-4185-8f2a-a40805b574ba"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("666216ee-9658-4db7-9898-b2cbf06d724c"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("a42b361d-4307-4146-ad70-cd17e72f4276"));

            migrationBuilder.DeleteData(
                table: "FileFormats",
                keyColumn: "Id",
                keyValue: new Guid("d0d5232d-5878-48bb-9186-fc3d345c5fe9"));

            migrationBuilder.DeleteData(
                table: "PaginationSettings",
                keyColumn: "Id",
                keyValue: new Guid("6e2d9e60-629e-42c2-8615-7c3fd61103d7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1fb4eeca-83cf-40d3-9854-98f0e0fa7bc6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6b900762-bb55-4618-b4e4-564138f4fc0b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6e17060d-a475-462b-8b0d-d3095bd3abba"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("76f273e9-5f18-4bb7-ba0d-1a0374cfb08e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b29b4f61-e7fa-4125-b368-cc636e021cc4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e9cf88cf-3033-41c0-950e-d7cfbb279910"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("2ca7d9a7-3b31-42e5-ad2d-c62b7d5ba7d7"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("56438c14-004a-4008-90df-6ac91093a4e0"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("688f3344-afdc-4680-b64c-57e9cbc467ac"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("af8ced53-6ac5-45ff-aaa4-eb5cd6277a2f"));

            migrationBuilder.DeleteData(
                table: "TimeZones",
                keyColumn: "Id",
                keyValue: new Guid("eaa5d070-1a0e-46bc-8005-d400444feb36"));

            migrationBuilder.CreateTable(
                name: "SitemapItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PageName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Slug = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccessByRole = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Icon = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsExternalLink = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExternalLink = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsHidden = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDisabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Version = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsPublished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PublishedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UnpublishBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UnpublishDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsUnpublished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDraft = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsArchived = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ArchivedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ArchivedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ParentItemId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    SitemapItemId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SitemapItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SitemapItems_SitemapItems_ParentItemId",
                        column: x => x.ParentItemId,
                        principalTable: "SitemapItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SitemapItems_SitemapItems_SitemapItemId",
                        column: x => x.SitemapItemId,
                        principalTable: "SitemapItems",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Slug = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Slug = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParentTopicId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_Topics_ParentTopicId",
                        column: x => x.ParentTopicId,
                        principalTable: "Topics",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Summary = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Excerpt = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Slug = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublishedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Author = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MetaDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UpdatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    DeletedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SitemapItemTopic",
                columns: table => new
                {
                    SitemapItemId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TopicsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SitemapItemTopic", x => new { x.SitemapItemId, x.TopicsId });
                    table.ForeignKey(
                        name: "FK_SitemapItemTopic_SitemapItems_SitemapItemId",
                        column: x => x.SitemapItemId,
                        principalTable: "SitemapItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SitemapItemTopic_Topics_TopicsId",
                        column: x => x.TopicsId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TagId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TopicId",
                table: "Posts",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_SitemapItems_ParentItemId",
                table: "SitemapItems",
                column: "ParentItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SitemapItems_SitemapItemId",
                table: "SitemapItems",
                column: "SitemapItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SitemapItemTopic_TopicsId",
                table: "SitemapItemTopic",
                column: "TopicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ParentTopicId",
                table: "Topics",
                column: "ParentTopicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "SitemapItemTopic");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "SitemapItems");

            migrationBuilder.DropTable(
                name: "Topics");

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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreatedAt", "IsActive", "IsoCode", "IsoCode3", "Name", "NativeName", "PhoneCode", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1b7856de-235e-4669-b343-5ddfbc0eeeef"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5051), true, "CH", "CHE", "Switzerland", "Schweiz", "+41", null },
                    { new Guid("3321a811-4ef8-4e01-a3f1-76f327a8bdc5"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5036), true, "FR", "FRA", "France", "France", "+33", null },
                    { new Guid("55e7dd8f-0b49-442f-80a2-1c34c05e6b9c"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5045), true, "IT", "ITA", "Italy", "Italia", "+39", null },
                    { new Guid("89fc43c9-0ff6-45d9-b523-943d0f286b1e"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5038), true, "DE", "DEU", "Germany", "Deutschland", "+49", null },
                    { new Guid("8b880caf-9bd4-4b1e-b0ff-185b67795588"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5043), true, "GB", "GBR", "United Kingdom", "United Kingdom", "+44", null },
                    { new Guid("8e54a7ed-fc5d-45e1-b2da-dac3dfb3e12e"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5047), true, "ES", "ESP", "Spain", "España", "+34", null },
                    { new Guid("d060a2c4-18df-4c2a-b12f-b9472d993f42"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5053), true, "AT", "AUT", "Austria", "Österreich", "+43", null },
                    { new Guid("f48ec768-9bf2-445a-bbc7-bcf424868923"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5041), true, "NL", "NLD", "Netherlands", "Nederland", "+31", null },
                    { new Guid("f659063e-1620-4e90-98f0-fa20beb2528c"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5033), true, "BE", "BEL", "Belgium", "België", "+32", null },
                    { new Guid("fb24e2cf-4940-4c6e-a7fb-ebd23ff22700"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5055), true, "LU", "LUX", "Luxembourg", "Luxembourg", "+352", null }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Code", "CreatedAt", "DecimalPlaces", "IsActive", "Name", "Symbol", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("2e41d2de-2495-496f-bde1-f82aaaa0d8ce"), "EUR", new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4913), 2, true, "Euro", "€", null },
                    { new Guid("65c70f44-0fab-442c-b4c3-3a8fccdeca3f"), "USD", new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4915), 2, true, "US Dollar", "$", null },
                    { new Guid("7672ca09-d81c-4db7-b154-8c48ce58e1ce"), "GBP", new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4918), 2, true, "British Pound", "£", null },
                    { new Guid("c4caabe2-ee97-4b09-aafa-7955132648a6"), "CHF", new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4919), 2, true, "Swiss Franc", "Fr.", null }
                });

            migrationBuilder.InsertData(
                table: "DateFormats",
                columns: new[] { "Id", "CreatedAt", "DisplayName", "Example", "Format", "IsActive", "IsDefault", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("025b7e8d-4b32-4811-b318-89477e0f1fd5"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4885), "US Date Format", "12/31/2024", "MM/dd/yyyy", true, false, null },
                    { new Guid("532ead27-9bf3-4dbe-9b7b-2e3435c205d0"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4887), "ISO Date Format", "2024-12-31", "yyyy-MM-dd", true, false, null },
                    { new Guid("94e9295e-07bb-4c07-a336-5cb76237e7ad"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4880), "Belgian/European Date Format", "31/12/2024", "dd/MM/yyyy", true, false, null },
                    { new Guid("b5a9b039-b530-4586-852a-f99ec742ddd2"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4883), "Belgian Date Format (Dot)", "31.12.2024", "dd.MM.yyyy", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "FileFormats",
                columns: new[] { "Id", "CreatedAt", "Description", "Extension", "IsActive", "IsDefault", "MaxSizeInMB", "MimeType", "Name", "SupportsAnnotations", "SupportsEditing", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("16d61393-81e2-4e46-a1cd-97a56a1219b5"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4813), "TypeScript React component file", ".tsx", true, false, 10, "application/typescript+react", "TypeScript React", true, false, null },
                    { new Guid("3c30fd5e-e7ef-41a3-af62-9effb3883f94"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4820), "JavaScript Object Notation data file", ".json", true, false, 10, "application/json", "JSON", true, false, null },
                    { new Guid("46566d1f-826e-4185-8f2a-a40805b574ba"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4822), "Markdown text format", ".md", true, false, 10, "text/markdown", "Markdown", true, false, null },
                    { new Guid("666216ee-9658-4db7-9898-b2cbf06d724c"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4811), "TypeScript source code file", ".ts", true, false, 10, "application/typescript", "TypeScript", true, false, null },
                    { new Guid("a42b361d-4307-4146-ad70-cd17e72f4276"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4818), "JavaScript source code file", ".js", true, false, 10, "application/javascript", "JavaScript", true, false, null },
                    { new Guid("d0d5232d-5878-48bb-9186-fc3d345c5fe9"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4805), "Simple text document format", ".txt", true, false, 10, "text/plain", "Plain Text", true, false, null }
                });

            migrationBuilder.InsertData(
                table: "PaginationSettings",
                columns: new[] { "Id", "CreatedAt", "EnableInfiniteScroll", "IsActive", "IsDefault", "ItemsPerPage", "PageSizeOptions", "ShowFirstLastButtons", "ShowItemsCount", "ShowPageNumbers", "ShowPageSizeSelector", "UpdatedAt", "VisiblePageRange" },
                values: new object[] { new Guid("6e2d9e60-629e-42c2-8615-7c3fd61103d7"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4855), false, true, false, 10, "[10,20,50,100]", true, true, true, true, null, 5 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("1fb4eeca-83cf-40d3-9854-98f0e0fa7bc6"), "Has full control over the application and can manage all aspects.", "SuperAdmin" },
                    { new Guid("6b900762-bb55-4618-b4e4-564138f4fc0b"), "Manages user interactions and content moderation. They can create and manage their own tasks, projects, and content, and can edit other public articles than their own.", "Moderator" },
                    { new Guid("6e17060d-a475-462b-8b0d-d3095bd3abba"), "Focuses on content creation and management without full administrative privileges. They can create and manage their own articles, but cannot edit other public articles than their own.", "Editor" },
                    { new Guid("76f273e9-5f18-4bb7-ba0d-1a0374cfb08e"), "Guest role is the least privileged role. They can only view public articles.", "Guest" },
                    { new Guid("b29b4f61-e7fa-4125-b368-cc636e021cc4"), "User role with limited privileges. A user can create and manage their own tasks, projects, and content, and cannot edit other public articles than their own.", "User" },
                    { new Guid("e9cf88cf-3033-41c0-950e-d7cfbb279910"), "Admin role has full administrative privileges, except for application management.", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "TimeZones",
                columns: new[] { "Id", "CreatedAt", "DstOffset", "IsActive", "Name", "StandardName", "UpdatedAt", "UsesDaylightSaving", "UtcOffset" },
                values: new object[,]
                {
                    { new Guid("2ca7d9a7-3b31-42e5-ad2d-c62b7d5ba7d7"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4947), "+02:00", true, "CET", "Central European Time (Belgium)", null, true, "+01:00" },
                    { new Guid("56438c14-004a-4008-90df-6ac91093a4e0"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4999), "+01:00", true, "WET", "Western European Time", null, true, "+00:00" },
                    { new Guid("688f3344-afdc-4680-b64c-57e9cbc467ac"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(5004), "+03:00", true, "EET", "Eastern European Time", null, true, "+02:00" },
                    { new Guid("af8ced53-6ac5-45ff-aaa4-eb5cd6277a2f"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4952), "+02:00", true, "UTC", "Coordinated Universal Time", null, true, "+00:00" },
                    { new Guid("eaa5d070-1a0e-46bc-8005-d400444feb36"), new DateTime(2025, 1, 28, 20, 21, 26, 987, DateTimeKind.Utc).AddTicks(4950), "+02:00", true, "CEST", "Central European Summer Time", null, true, "+02:00" }
                });
        }
    }
}
