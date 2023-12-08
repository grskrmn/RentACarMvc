using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EfCore.Configurations
{
    public class RentalConfig : BaseEntityConfig<Rental>
    {
        public override void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.ToTable("rentals");
            builder.Property(x => x.Id).HasColumnName("rental_id");
            builder.Property(x => x.ModelId).HasColumnName("model_id");
            builder.Property(x => x.UserId).HasColumnName("user_id");
            builder.Property(x => x.Line1).HasColumnName("address");
            builder.Property(x => x.Line2).HasColumnName("address_optional");
            builder.Property(x => x.Country).HasColumnName("country");
            builder.Property(x => x.City).HasColumnName("city");
            builder.Property(x => x.Zip).HasColumnName("zip");
            builder.Property(x => x.RentedDate).HasColumnName("rented_date").HasDefaultValue(DateTime.UtcNow);
            builder.Property(x => x.RentStartDate).HasColumnName("rent_start_date");
            builder.Property(x => x.RentStartDate).HasColumnName("rent_start_date");
            builder.Property(x => x.RentEndDate).HasColumnName("rent_end_date");
            builder.Property(x => x.Status).HasColumnName("status");

            builder.HasOne(x => x.Model);
           
        }
    }
}