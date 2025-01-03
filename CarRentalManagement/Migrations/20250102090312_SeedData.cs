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
                    { 1, "System", new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(1960), new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(1978), "Black", "System" },
                    { 2, "System", new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(1980), new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(1981), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2276), new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2279), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2280), new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2281), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2395), new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2396), "i4", "System" },
                    { 2, "System", new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2397), new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2398), "X5", "System" },
                    { 3, "System", new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2399), new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2400), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2401), new DateTime(2025, 1, 2, 17, 3, 11, 993, DateTimeKind.Local).AddTicks(2401), "C-HR", "System" }
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
