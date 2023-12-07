using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EfCore.Configurations
{
    public class ModelConfig : BaseEntityConfig<Model>
    {
        public override void Configure(EntityTypeBuilder<Model> builder)
        {
           
            builder.ToTable("models");

            builder.Property(x => x.Id).HasColumnName("model_id");
            builder.Property(x => x.BrandId).HasColumnName("brand_id");
            builder.Property(x => x.ColorId).HasColumnName("color_id");
            builder.Property(x => x.Name).HasColumnName("model_name");
            builder.Property(x => x.DailyPrice).HasColumnName("daily_price");
            builder.Property(x => x.ModelYear).HasColumnName("model_year");
            builder.Property(x => x.Capacity).HasColumnName("capacity");
            builder.Property(x => x.Description).HasColumnName("description");

            builder.HasOne(x => x.Brand);
            builder.HasOne(x => x.Color);

            builder.HasData(
                new Model(){Id = 1, BrandId = 1, ModelYear = 2023, ColorId = 1, Capacity = 4, DailyPrice = 750, Description = "Yeni elektirikli togg.", Name = "X10", CreatedAt = DateTime.UtcNow.AddDays(-2), UpdatedDate = null},
                new Model(){Id = 2, BrandId = 1, ModelYear = 2023, ColorId = 3, Capacity = 4, DailyPrice = 750, Description = "Yeni elektirikli x10 togg.", Name = "X10", CreatedAt = DateTime.UtcNow.AddDays(-3), UpdatedDate = null},
                new Model(){Id = 3, BrandId = 2, ModelYear = 2021, ColorId = 3, Capacity = 4, DailyPrice = 650, Description = "Ford fieasta.", Name = "Fiesta", CreatedAt = DateTime.UtcNow.AddDays(-20), UpdatedDate = null},
                new Model(){Id = 4, BrandId = 1, ModelYear = 2022, ColorId = 1, Capacity = 4, DailyPrice = 650, Description = "Togg x10.", Name = "X10", CreatedAt = DateTime.UtcNow.AddDays(-100), UpdatedDate = null},
                new Model(){Id = 5, BrandId = 2, ModelYear = 2020, ColorId = 3, Capacity = 4, DailyPrice = 870, Description = "Ford focus.", Name = "Focus", CreatedAt = DateTime.UtcNow.AddDays(-28), UpdatedDate = null},
                new Model(){Id = 6, BrandId = 3, ModelYear = 2019, ColorId = 1, Capacity = 4, DailyPrice = 340, Description = "Hyundai i20.", Name = "I20", CreatedAt = DateTime.UtcNow.AddDays(-10), UpdatedDate = null},
                new Model(){Id = 7, BrandId = 3, ModelYear = 2022, ColorId = 2, Capacity = 4, DailyPrice = 768, Description = "Hyundai accent blue.", Name = "Accent Blue", CreatedAt = DateTime.UtcNow.AddDays(-39), UpdatedDate = null},
                new Model(){Id = 8, BrandId = 4, ModelYear = 2023, ColorId = 2, Capacity = 4, DailyPrice = 900, Description = "Renault Megane.", Name = "Megane", CreatedAt = DateTime.UtcNow.AddDays(-42), UpdatedDate = null},
                new Model(){Id = 9, BrandId = 4, ModelYear = 2020, ColorId = 3, Capacity = 4, DailyPrice = 570, Description = "Renault symbol.", Name = "Symbol", CreatedAt = DateTime.UtcNow.AddDays(-22), UpdatedDate = null},
                new Model(){Id = 10, BrandId = 2, ModelYear = 2018, ColorId = 3, Capacity = 4, DailyPrice = 754, Description = "Ford connect.", Name = "Connect", CreatedAt = DateTime.UtcNow.AddDays(-76), UpdatedDate = null}
            );
        }
    }
}