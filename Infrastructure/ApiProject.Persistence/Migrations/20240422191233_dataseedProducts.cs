using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dataseedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 12, 33, 521, DateTimeKind.Local).AddTicks(2863), "bəzək, Geyim & Oyuncaqlar" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 12, 33, 521, DateTimeKind.Local).AddTicks(2990), "Oyuncaqlar & bəzək" });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 12, 33, 521, DateTimeKind.Local).AddTicks(3003), "Geyim, turizm & Avtomobil" });

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 23, 12, 33, 521, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 23, 12, 33, 521, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 23, 12, 33, 521, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 23, 12, 33, 521, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 12, 33, 523, DateTimeKind.Local).AddTicks(5373), "Fuga et assumenda laboriosam nihil.", "Praesentium." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 12, 33, 523, DateTimeKind.Local).AddTicks(5520), "Est temporibus et aut et.", "Et." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 12, 33, 523, DateTimeKind.Local).AddTicks(5554), "Ducimus ut placeat nesciunt consequatur.", "Laudantium." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 0, 52, 37, 59, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 52, 37, 62, DateTimeKind.Local).AddTicks(2629), "Et id aut et qui.", "Porro." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 52, 37, 62, DateTimeKind.Local).AddTicks(2786), "Aut non ut voluptas voluptatem.", "Voluptas." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 19, 0, 52, 37, 62, DateTimeKind.Local).AddTicks(2819), "Animi distinctio qui architecto deleniti.", "Itaque." });
        }
    }
}
