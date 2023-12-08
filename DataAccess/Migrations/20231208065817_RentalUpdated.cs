using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RentalUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13b26b31-6a37-46dc-b8bf-736ce11f0eed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c41d400-935d-4d1c-9833-bed73c617254");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7923ea06-9b20-4f10-a094-26d0da6effb7");

            migrationBuilder.RenameColumn(
                name: "renturn_date",
                table: "rentals",
                newName: "rent_end_date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "rented_date",
                table: "rentals",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 8, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(9765),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "rentals",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address_optional",
                table: "rentals",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "rentals",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "rentals",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "rent_start_date",
                table: "rentals",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "zip",
                table: "rentals",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bbcdcb11-614e-4451-95a2-7eb605a5e1f8", null, "User", "USER" },
                    { "c621111e-6135-41af-9bf2-68b6e00f412a", null, "Editor", "EDITOR" },
                    { "d80920b1-1a83-429a-ac2c-cf6977216221", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 4, 6, 58, 17, 352, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 5, 6, 58, 17, 352, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 6, 58, 17, 352, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 6, 58, 17, 352, DateTimeKind.Utc).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 6, 58, 17, 352, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "colors",
                keyColumn: "color_id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 8, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "colors",
                keyColumn: "color_id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "colors",
                keyColumn: "color_id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 8, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "colors",
                keyColumn: "color_id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 7, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 5, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 18, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 10, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 28, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 30, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 27, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 16, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 23, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(6952));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbcdcb11-614e-4451-95a2-7eb605a5e1f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c621111e-6135-41af-9bf2-68b6e00f412a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d80920b1-1a83-429a-ac2c-cf6977216221");

            migrationBuilder.DropColumn(
                name: "address",
                table: "rentals");

            migrationBuilder.DropColumn(
                name: "address_optional",
                table: "rentals");

            migrationBuilder.DropColumn(
                name: "city",
                table: "rentals");

            migrationBuilder.DropColumn(
                name: "country",
                table: "rentals");

            migrationBuilder.DropColumn(
                name: "rent_start_date",
                table: "rentals");

            migrationBuilder.DropColumn(
                name: "zip",
                table: "rentals");

            migrationBuilder.RenameColumn(
                name: "rent_end_date",
                table: "rentals",
                newName: "renturn_date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "rented_date",
                table: "rentals",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2023, 12, 8, 6, 58, 17, 353, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13b26b31-6a37-46dc-b8bf-736ce11f0eed", null, "Editor", "EDITOR" },
                    { "4c41d400-935d-4d1c-9833-bed73c617254", null, "User", "USER" },
                    { "7923ea06-9b20-4f10-a094-26d0da6effb7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 4, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 5, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "brands",
                keyColumn: "brand_id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "colors",
                keyColumn: "color_id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 8, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "colors",
                keyColumn: "color_id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "colors",
                keyColumn: "color_id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 8, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "colors",
                keyColumn: "color_id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 7, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 6, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 5, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 18, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 8, 30, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 10, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 28, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 30, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2023, 10, 27, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 16, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "models",
                keyColumn: "model_id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 23, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3223));
        }
    }
}
