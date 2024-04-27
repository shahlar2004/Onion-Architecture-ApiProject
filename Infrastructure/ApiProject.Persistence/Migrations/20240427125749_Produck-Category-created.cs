using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ProduckCategorycreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

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

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 57, 49, 516, DateTimeKind.Local).AddTicks(6825), "Ev" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 57, 49, 516, DateTimeKind.Local).AddTicks(6911), "Oyuncaqlar & İdman" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 57, 49, 516, DateTimeKind.Local).AddTicks(9864), "Kompyuterlər" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 16, 57, 49, 517, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 16, 57, 49, 517, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 16, 57, 49, 517, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 16, 57, 49, 517, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 57, 49, 520, DateTimeKind.Local).AddTicks(9073), "Quo voluptates quia rerum iste.", "Ea." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 57, 49, 520, DateTimeKind.Local).AddTicks(9290), "Adipisci eum iure enim itaque." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 57, 49, 520, DateTimeKind.Local).AddTicks(9340), "Voluptate fuga omnis sed nemo.", "Iure." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 57, 49, 524, DateTimeKind.Local).AddTicks(9886), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4.212197629638790m, 752.24m, "İnanılmaz Rezin Beret" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 57, 49, 525, DateTimeKind.Local).AddTicks(109), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5.768720119760420m, 845.24m, "Mükəmməl Polad Kompyuter" });

            migrationBuilder.CreateIndex(
                name: "IX_productsCategory_CategoryId",
                table: "productsCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productsCategory");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 824, DateTimeKind.Local).AddTicks(7080), "Filmlər & Ayyaqqabı" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 824, DateTimeKind.Local).AddTicks(7201), "Ayyaqqabı, Elektronika & oyunlar" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 824, DateTimeKind.Local).AddTicks(7221), "İdman" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 23, 13, 49, 825, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 23, 13, 49, 825, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 23, 13, 49, 825, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 23, 13, 49, 825, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 828, DateTimeKind.Local).AddTicks(589), "Dolores autem aliquid nostrum odit.", "Excepturi." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 828, DateTimeKind.Local).AddTicks(767), "Dolor autem hic odio et." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 828, DateTimeKind.Local).AddTicks(805), "Iure tempore sint aperiam quod.", "Voluptatem." });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 831, DateTimeKind.Local).AddTicks(1235), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1.652621210522590m, 395.15m, "Əlverişli Pambıq Beret" });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 831, DateTimeKind.Local).AddTicks(1415), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9.542020942142080m, 595.75m, "Balaca Rezin Kulon" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
