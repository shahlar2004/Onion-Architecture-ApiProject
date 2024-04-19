using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class configurationEnding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(2485), "İdman" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(2565), "musiqi & uşaq üçün" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(2614), "turizm, Ayyaqqabı & musiqi" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(5798), false, "Elektrik", 0, 1 },
                    { 2, new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(5802), false, "Moda", 0, 2 },
                    { 3, new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(5803), false, "Bilgisayar", 1, 1 },
                    { 4, new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(5803), false, "Qadın", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 19, 0, 52, 37, 62, DateTimeKind.Local).AddTicks(2629), "Et id aut et qui.", false, "Porro." },
                    { 2, 3, new DateTime(2024, 4, 19, 0, 52, 37, 62, DateTimeKind.Local).AddTicks(2786), "Aut non ut voluptas voluptatem.", true, "Voluptas." },
                    { 3, 4, new DateTime(2024, 4, 19, 0, 52, 37, 62, DateTimeKind.Local).AddTicks(2819), "Animi distinctio qui architecto deleniti.", false, "Itaque." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 18, 23, 44, 18, 109, DateTimeKind.Local).AddTicks(6935), "Kompyuterlər & turizm" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 18, 23, 44, 18, 109, DateTimeKind.Local).AddTicks(7184), "turizm" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 18, 23, 44, 18, 109, DateTimeKind.Local).AddTicks(7193), "oyunlar & musiqi" });
        }
    }
}
