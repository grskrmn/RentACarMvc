using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ColorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 8, 0, 22, 15, 817, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 9, 0, 22, 15, 817, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 10, 0, 22, 15, 817, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 12, 0, 22, 15, 817, DateTimeKind.Utc).AddTicks(6582), "Mavi", null },
                    { 2, new DateTime(2023, 11, 10, 0, 22, 15, 817, DateTimeKind.Utc).AddTicks(6585), "Kırmızı", null },
                    { 3, new DateTime(2023, 11, 12, 0, 22, 15, 817, DateTimeKind.Utc).AddTicks(6588), "Beyaz", null },
                    { 4, new DateTime(2023, 11, 11, 0, 22, 15, 817, DateTimeKind.Utc).AddTicks(6590), "Siyah", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 6, 22, 55, 6, 541, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 7, 22, 55, 6, 541, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 11, 8, 22, 55, 6, 541, DateTimeKind.Utc).AddTicks(5045));
        }
    }
}
