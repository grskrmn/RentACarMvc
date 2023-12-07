using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EfCore.Configurations
{
    public class BrandConfig : BaseEntityConfig<Brand>
    {
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("brands");
            


            builder.Property(x => x.Id).HasColumnName("brand_id");
            builder.Property(x => x.Name).HasColumnName("brand_name");

            builder.HasMany(x => x.Models);
            builder.HasData(new Brand[]{

                new() {Id = 1, Name = "Togg", CreatedAt = DateTime.UtcNow.AddDays(-4), UpdatedDate = null},
                new(){Id = 2, Name = "Ford", CreatedAt= DateTime.UtcNow.AddDays(-3), UpdatedDate = null},
                new(){Id = 3, Name = "Hyundai", CreatedAt = DateTime.UtcNow.AddDays(-2), UpdatedDate = null},
                new(){Id = 4, Name = "Renault", CreatedAt = DateTime.UtcNow.AddDays(-2), UpdatedDate = null},
                new(){Id = 5, Name = "Fiat", CreatedAt = DateTime.UtcNow.AddDays(-2), UpdatedDate = null},
            });
        }
    }
}