using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "59e3dc30-4114-40a4-9f5c-fbe388bf7dfe", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHC3iOx4XrgUIqUIr4lMPN/QjPplDlcP/NeKQSalNnmcJ3AvCnO5MVF7XaKehZ9CIw==", null, false, "4f41922d-426d-46ee-ac28-a759b0cb1bd8", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1587), new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1601), new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1762), new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1764), new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1843), new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1845), new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1846), new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1848), new DateTime(2025, 1, 2, 17, 39, 35, 536, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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
                values: new object[] { new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9429), new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9443), new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9620), new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9622), new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9703), new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9705), new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9706), new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9708), new DateTime(2025, 1, 2, 17, 22, 53, 782, DateTimeKind.Local).AddTicks(9708) });
        }
    }
}
