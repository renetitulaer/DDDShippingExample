using Domain.Aggrgates.CargoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistency.Configurations
{
    public class CargoSpecificationConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.Ignore(x => x.ShippingDbContext);
            builder.HasKey(x => x.TrackingId);
            builder.Property(x => x.TrackingId).ValueGeneratedOnAdd();
            builder.OwnsOne(e => e.DeliveryGoal, a =>
            {
                a.Property(x => x.ArrivelTime).HasColumnName("DeliveryGoalArrivelTime");
                a.Property(x => x.DestinationId).HasColumnName("DeliveryGoalDestinationId");
            });
        }
    }
}
