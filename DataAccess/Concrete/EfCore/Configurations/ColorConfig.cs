using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EfCore.Configurations
{
    public class ColorConfig : BaseEntityConfig<Color>
    {
        public override void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("colors");
          
            
            builder.Property(x => x.Id).HasColumnName("color_id");
            builder.Property(x => x.Name).HasColumnName("color_name");
            builder.HasMany(x => x.Models);
            builder.HasData(new Color[]{
                new(){Id = 1, Name = "Mavi", CreatedAt = DateTime.UtcNow, UpdatedDate = null},
                new(){Id = 2, Name = "Kırmızı", CreatedAt = DateTime.UtcNow.AddDays(-2), UpdatedDate = null},
                new(){Id = 3, Name = "Beyaz", CreatedAt = DateTime.UtcNow, UpdatedDate = null},
                new(){Id = 4, Name = "Siyah", CreatedAt = DateTime.UtcNow.AddDays(-1), UpdatedDate = null}
            });
        }
    }
}