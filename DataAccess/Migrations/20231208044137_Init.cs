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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "rentals",
                columns: table => new
                {
                    rentalid = table.Column<int>(name: "rental_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    modelid = table.Column<int>(name: "model_id", type: "integer", nullable: false),
                    userid = table.Column<string>(name: "user_id", type: "text", nullable: true),
                    renteddate = table.Column<DateTime>(name: "rented_date", type: "timestamp with time zone", nullable: false),
                    renturndate = table.Column<DateTime>(name: "renturn_date", type: "timestamp with time zone", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rentals", x => x.rentalid);
                    table.ForeignKey(
                        name: "FK_rentals_AspNetUsers_user_id",
                        column: x => x.userid,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_rentals_models_model_id",
                        column: x => x.modelid,
                        principalTable: "models",
                        principalColumn: "model_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13b26b31-6a37-46dc-b8bf-736ce11f0eed", null, "Editor", "EDITOR" },
                    { "4c41d400-935d-4d1c-9833-bed73c617254", null, "User", "USER" },
                    { "7923ea06-9b20-4f10-a094-26d0da6effb7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "brands",
                columns: new[] { "brand_id", "CreatedAt", "brand_name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 4, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5215), "Togg", null },
                    { 2, new DateTime(2023, 12, 5, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5227), "Ford", null },
                    { 3, new DateTime(2023, 12, 6, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5229), "Hyundai", null },
                    { 4, new DateTime(2023, 12, 6, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5231), "Renault", null },
                    { 5, new DateTime(2023, 12, 6, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(5232), "Fiat", null }
                });

            migrationBuilder.InsertData(
                table: "colors",
                columns: new[] { "color_id", "CreatedAt", "color_name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 8, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(8448), "Mavi", null },
                    { 2, new DateTime(2023, 12, 6, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(8451), "Kırmızı", null },
                    { 3, new DateTime(2023, 12, 8, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(8453), "Beyaz", null },
                    { 4, new DateTime(2023, 12, 7, 4, 41, 37, 417, DateTimeKind.Utc).AddTicks(8455), "Siyah", null }
                });

            migrationBuilder.InsertData(
                table: "models",
                columns: new[] { "model_id", "brand_id", "capacity", "color_id", "CreatedAt", "daily_price", "description", "model_year", "model_name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 4, 1, new DateTime(2023, 12, 6, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3200), 750m, "Yeni elektirikli togg.", 2023, "X10", null },
                    { 2, 1, 4, 3, new DateTime(2023, 12, 5, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3206), 750m, "Yeni elektirikli x10 togg.", 2023, "X10", null },
                    { 3, 2, 4, 3, new DateTime(2023, 11, 18, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3208), 650m, "Ford fieasta.", 2021, "Fiesta", null },
                    { 4, 1, 4, 1, new DateTime(2023, 8, 30, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3210), 650m, "Togg x10.", 2022, "X10", null },
                    { 5, 2, 4, 3, new DateTime(2023, 11, 10, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3212), 870m, "Ford focus.", 2020, "Focus", null },
                    { 6, 3, 4, 1, new DateTime(2023, 11, 28, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3215), 340m, "Hyundai i20.", 2019, "I20", null },
                    { 7, 3, 4, 2, new DateTime(2023, 10, 30, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3217), 768m, "Hyundai accent blue.", 2022, "Accent Blue", null },
                    { 8, 4, 4, 2, new DateTime(2023, 10, 27, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3219), 900m, "Renault Megane.", 2023, "Megane", null },
                    { 9, 4, 4, 3, new DateTime(2023, 11, 16, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3221), 570m, "Renault symbol.", 2020, "Symbol", null },
                    { 10, 2, 4, 3, new DateTime(2023, 9, 23, 4, 41, 37, 418, DateTimeKind.Utc).AddTicks(3223), 754m, "Ford connect.", 2018, "Connect", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_models_brand_id",
                table: "models",
                column: "brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_models_color_id",
                table: "models",
                column: "color_id");

            migrationBuilder.CreateIndex(
                name: "IX_rentals_model_id",
                table: "rentals",
                column: "model_id");

            migrationBuilder.CreateIndex(
                name: "IX_rentals_user_id",
                table: "rentals",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "rentals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "models");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "colors");
        }
    }
}
