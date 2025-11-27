using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(529), new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(547), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(553), new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(554), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1133), new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1134), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1137), new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1138), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1410), new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1413), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1417), new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1418), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1421), new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1423), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1426), new DateTime(2025, 11, 25, 21, 49, 34, 542, DateTimeKind.Local).AddTicks(1427), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
