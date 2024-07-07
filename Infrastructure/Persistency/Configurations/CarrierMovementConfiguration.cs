using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CarrierMovementAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistency.Configurations
{
    public class CarrierMovementConfiguration : IEntityTypeConfiguration<CarrierMovement>
    {
        public void Configure(EntityTypeBuilder<CarrierMovement> builder)
        {
            builder.HasKey(x => x.ScheduleId);
            builder.HasOne(x => x.FromLocation).WithMany().OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.ToLocation).WithMany().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
