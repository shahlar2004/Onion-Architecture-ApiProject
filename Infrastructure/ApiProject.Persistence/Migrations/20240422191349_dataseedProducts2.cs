using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dataseedProducts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 828, DateTimeKind.Local).AddTicks(767), "Dolor autem hic odio et.", "Est." });

            migrationBuilder.UpdateData(
                table: "details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2024, 4, 22, 23, 13, 49, 828, DateTimeKind.Local).AddTicks(805), "Iure tempore sint aperiam quod.", "Voluptatem." });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 4, 22, 23, 13, 49, 831, DateTimeKind.Local).AddTicks(1235), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1.652621210522590m, false, 395.15m, "Əlverişli Pambıq Beret" },
                    { 2, 1, new DateTime(2024, 4, 22, 23, 13, 49, 831, DateTimeKind.Local).AddTicks(1415), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9.542020942142080m, false, 595.75m, "Balaca Rezin Kulon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

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
    }
}
