using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(7808), new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(7834), new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8222), new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8227), new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8405), new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8409), new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8413), new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 11, 27, 9, 47, 18, 850, DateTimeKind.Local).AddTicks(8418) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(8674), new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(8703), new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9101), new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9106), new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9436), new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9440), new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9444), new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9447), new DateTime(2025, 11, 27, 9, 25, 49, 219, DateTimeKind.Local).AddTicks(9449) });
        }
    }
}
