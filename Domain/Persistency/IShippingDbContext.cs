using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CarrierMovementAggregate;
using Domain.Aggrgates.CustomerAggregate;
using Domain.Aggrgates.HandlingIncidentAggregate;
using Domain.Aggrgates.LocationAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistency
{
    public interface IShippingDbContext
    {
        DbSet<Cargo> Cargos { get; }

        DbSet<CarrierMovement> CarrierMovements { get; }

        DbSet<Customer> Customers { get; }

        DbSet<HandlingEvent> HandlingEvents { get; }

        DbSet<Location> Locations { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
