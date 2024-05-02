using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initalCreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_details_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productsCategory",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productsCategory", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_productsCategory_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productsCategory_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 16, 2, 38, 802, DateTimeKind.Local).AddTicks(3009), false, "Kompyuterlər" },
                    { 2, new DateTime(2024, 4, 28, 16, 2, 38, 802, DateTimeKind.Local).AddTicks(3118), false, "Geyim" },
                    { 3, new DateTime(2024, 4, 28, 16, 2, 38, 802, DateTimeKind.Local).AddTicks(3128), true, "Ayyaqqabı & Səhiyyə" }
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 28, 16, 2, 38, 802, DateTimeKind.Local).AddTicks(8521), false, "Elektrik", 0, 1 },
                    { 2, new DateTime(2024, 4, 28, 16, 2, 38, 802, DateTimeKind.Local).AddTicks(8527), false, "Moda", 0, 2 },
                    { 3, new DateTime(2024, 4, 28, 16, 2, 38, 802, DateTimeKind.Local).AddTicks(8528), false, "Bilgisayar", 1, 1 },
                    { 4, new DateTime(2024, 4, 28, 16, 2, 38, 802, DateTimeKind.Local).AddTicks(8530), false, "Qadın", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 28, 16, 2, 38, 805, DateTimeKind.Local).AddTicks(9256), "Perferendis voluptatem qui aspernatur et.", false, "Facere." },
                    { 2, 3, new DateTime(2024, 4, 28, 16, 2, 38, 805, DateTimeKind.Local).AddTicks(9484), "Placeat consectetur et aperiam non.", true, "Temporibus." },
                    { 3, 4, new DateTime(2024, 4, 28, 16, 2, 38, 805, DateTimeKind.Local).AddTicks(9607), "Doloribus aut consectetur delectus et.", false, "Dolor." }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 28, 16, 2, 38, 810, DateTimeKind.Local).AddTicks(5181), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 8.488637953133320m, false, 605.33m, "Möhtəşəm Polad Sviter" },
                    { 2, 1, new DateTime(2024, 4, 28, 16, 2, 38, 810, DateTimeKind.Local).AddTicks(5455), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4.918328606960130m, false, 944.66m, "Fantastik Polad Sviter" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_details_CategoryId",
                table: "details",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_products_BrandId",
                table: "products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_productsCategory_CategoryId",
                table: "productsCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "details");

            migrationBuilder.DropTable(
                name: "productsCategory");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "brands");
        }
    }
}
