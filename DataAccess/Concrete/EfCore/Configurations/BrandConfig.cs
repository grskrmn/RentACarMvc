using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EfCore.Configurations
{
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(new Brand[]{

                new() {Id = 1, Name = "Togg", CreatedAt = DateTime.UtcNow.AddDays(-4), UpdatedDate = null},
                new(){Id = 2, Name = "Ford", CreatedAt= DateTime.UtcNow.AddDays(-3), UpdatedDate = null},
                new(){Id = 3, Name = "Mercedes", CreatedAt = DateTime.UtcNow.AddDays(-2), UpdatedDate = null}
            });
        }
    }
}