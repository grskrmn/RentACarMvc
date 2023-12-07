﻿// <auto-generated />
using System;
using DataAccess.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(RentACarDbContext))]
    [Migration("20231205123553_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("brand_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("brand_name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("brands", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 1, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2202),
                            Name = "Togg"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 2, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2214),
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 12, 3, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2215),
                            Name = "Hyundai"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 12, 3, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2217),
                            Name = "Renault"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2023, 12, 3, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(2218),
                            Name = "Fiat"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("color_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("color_name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("colors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 12, 5, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(6567),
                            Name = "Mavi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 12, 3, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(6570),
                            Name = "Kırmızı"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 12, 5, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(6573),
                            Name = "Beyaz"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2023, 12, 4, 12, 35, 53, 93, DateTimeKind.Utc).AddTicks(6575),
                            Name = "Siyah"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("model_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("integer")
                        .HasColumnName("brand_id");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<int>("ColorId")
                        .HasColumnType("integer")
                        .HasColumnName("color_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("DailyPrice")
                        .HasColumnType("numeric")
                        .HasColumnName("daily_price");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("ModelYear")
                        .HasColumnType("integer")
                        .HasColumnName("model_year");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("model_name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.ToTable("models", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Capacity = 4,
                            ColorId = 1,
                            CreatedAt = new DateTime(2023, 12, 3, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1093),
                            DailyPrice = 750m,
                            Description = "Yeni elektirikli togg.",
                            ModelYear = 2023,
                            Name = "X10"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            Capacity = 4,
                            ColorId = 3,
                            CreatedAt = new DateTime(2023, 12, 2, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1102),
                            DailyPrice = 750m,
                            Description = "Yeni elektirikli x10 togg.",
                            ModelYear = 2023,
                            Name = "X10"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 2,
                            Capacity = 4,
                            ColorId = 3,
                            CreatedAt = new DateTime(2023, 11, 15, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1105),
                            DailyPrice = 650m,
                            Description = "Ford fieasta.",
                            ModelYear = 2021,
                            Name = "Fiesta"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1,
                            Capacity = 4,
                            ColorId = 1,
                            CreatedAt = new DateTime(2023, 8, 27, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1107),
                            DailyPrice = 650m,
                            Description = "Togg x10.",
                            ModelYear = 2022,
                            Name = "X10"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 2,
                            Capacity = 4,
                            ColorId = 3,
                            CreatedAt = new DateTime(2023, 11, 7, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1110),
                            DailyPrice = 870m,
                            Description = "Ford focus.",
                            ModelYear = 2020,
                            Name = "Focus"
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 3,
                            Capacity = 4,
                            ColorId = 1,
                            CreatedAt = new DateTime(2023, 11, 25, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1112),
                            DailyPrice = 340m,
                            Description = "Hyundai i20.",
                            ModelYear = 2019,
                            Name = "I20"
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 3,
                            Capacity = 4,
                            ColorId = 2,
                            CreatedAt = new DateTime(2023, 10, 27, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1115),
                            DailyPrice = 768m,
                            Description = "Hyundai accent blue.",
                            ModelYear = 2022,
                            Name = "Accent Blue"
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 4,
                            Capacity = 4,
                            ColorId = 2,
                            CreatedAt = new DateTime(2023, 10, 24, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1117),
                            DailyPrice = 900m,
                            Description = "Renault Megane.",
                            ModelYear = 2023,
                            Name = "Megane"
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 4,
                            Capacity = 4,
                            ColorId = 3,
                            CreatedAt = new DateTime(2023, 11, 13, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1119),
                            DailyPrice = 570m,
                            Description = "Renault symbol.",
                            ModelYear = 2020,
                            Name = "Symbol"
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 2,
                            Capacity = 4,
                            ColorId = 3,
                            CreatedAt = new DateTime(2023, 9, 20, 12, 35, 53, 94, DateTimeKind.Utc).AddTicks(1122),
                            DailyPrice = 754m,
                            Description = "Ford connect.",
                            ModelYear = 2018,
                            Name = "Connect"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Model", b =>
                {
                    b.HasOne("Entities.Concrete.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Color", "Color")
                        .WithMany("Models")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}