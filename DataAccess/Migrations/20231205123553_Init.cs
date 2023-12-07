using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    brandid = table.Column<int>(name: "brand_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    brandname = table.Column<string>(name: "brand_name", type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.brandid);
                });

            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    colorid = table.Column<int>(name: "color_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    colorname = table.Column<string>(name: "color_name", type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colors", x => x.colorid);
                });

            migrationBuilder.CreateTable(
                name: "models",
                columns: table => new
                {
                    modelid = table.Column<int>(name: "model_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    brandid = table.Column<int>(name: "brand_id", type: "integer", nullable: false),
                    colorid = table.Column<int>(name: "color_id", type: "integer", nullable: false),
                    modelname = table.Column<string>(name: "model_name", type: "text", nullable: true),
                    modelyear = table.Column<int>(name: "model_year", type: "integer", nullable: false),
                    dailyprice = table.Column<decimal>(name: "daily_price", type: "numeric", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    capacity = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_models", x => x.modelid);
                    table.ForeignKey(
                        name: "FK_models_brands_brand_id",
                        column: x => x.brandid,
                        principalTable: "brands",
                        principalColumn: "brand_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_models_colors_color_id",
                        column: x => x.colorid,
                        principalTable: "colors",
                        principalColumn: "color_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "brand_id", "CreatedAt", "brand_name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 1, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2202), "Togg", null },
                    { 2, new DateTime(2023, 12, 2, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2214), "Ford", null },
                    { 3, new DateTime(2023, 12, 3, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2215), "Hyundai", null },
                    { 4, new DateTime(2023, 12, 3, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2217), "Renault", null },
                    { 5, new DateTime(2023, 12, 3, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2218), "Fiat", null }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "color_id", "CreatedAt", "color_name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 5, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(6567), "Mavi", null },
                    { 2, new DateTime(2023, 12, 3, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(6570), "Kırmızı", null },
                    { 3, new DateTime(2023, 12, 5, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(6573), "Beyaz", null },
                    { 4, new DateTime(2023, 12, 4, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(6575), "Siyah", null }
                });

            migrationBuilder.InsertData(
                table: "models",
                columns: new[] { "model_id", "brand_id", "capacity", "color_id", "CreatedAt", "daily_price", "description", "model_year", "model_name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 4, 1, new DateTime(2023, 12, 3, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1093), 750m, "Yeni elektirikli togg.", 2023, "X10", null },
                    { 2, 1, 4, 3, new DateTime(2023, 12, 2, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1102), 750m, "Yeni elektirikli x10 togg.", 2023, "X10", null },
                    { 3, 2, 4, 3, new DateTime(2023, 11, 15, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1105), 650m, "Ford fieasta.", 2021, "Fiesta", null },
                    { 4, 1, 4, 1, new DateTime(2023, 8, 27, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1107), 650m, "Togg x10.", 2022, "X10", null },
                    { 5, 2, 4, 3, new DateTime(2023, 11, 7, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1110), 870m, "Ford focus.", 2020, "Focus", null },
                    { 6, 3, 4, 1, new DateTime(2023, 11, 25, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1112), 340m, "Hyundai i20.", 2019, "I20", null },
                    { 7, 3, 4, 2, new DateTime(2023, 10, 27, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1115), 768m, "Hyundai accent blue.", 2022, "Accent Blue", null },
                    { 8, 4, 4, 2, new DateTime(2023, 10, 24, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1117), 900m, "Renault Megane.", 2023, "Megane", null },
                    { 9, 4, 4, 3, new DateTime(2023, 11, 13, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1119), 570m, "Renault symbol.", 2020, "Symbol", null },
                    { 10, 2, 4, 3, new DateTime(2023, 9, 20, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1122), 754m, "Ford connect.", 2018, "Connect", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_models_brand_id",
                table: "models",
                column: "brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_models_color_id",
                table: "models",
                column: "color_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "models");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "colors");
        }
    }
}
