using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "DairyId", "CreatedAt", "Description", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 13, 7, 47, 14, 961, DateTimeKind.Local).AddTicks(2170), "Felipe comio pizza", "Felipe en la pizzeria" },
                    { 2, new DateTime(2025, 5, 13, 7, 47, 14, 961, DateTimeKind.Local).AddTicks(2173), "Felipe comio helado", "Felipe en la heladeria" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "DairyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "DairyId",
                keyValue: 2);
        }
    }
}
