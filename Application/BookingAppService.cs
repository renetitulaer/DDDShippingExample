using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CustomerAggregate;
using Domain.Aggrgates.LocationAggregate;
using Domain.Persistency;
using Infrastructure.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class BookingAppService
    {
        public void CreateCargo()
        {

            using (var shippContext = new ShippingDbContext())
            {
                var customer = shippContext.Customers.Single(c => c.Name == "Cargo Care");
                var destination = shippContext.Locations.Single(l => l.PortCode == "VenloB2");

                var cargo = new CargoFactory(shippContext).CreateCargo(customer,
                                   new DeliverySpecification(new DateTime(2025, 1, 1), destination.LocationId));
                shippContext.Cargos.Add(cargo);
                shippContext.SaveChanges();
            }
        }

        public void ChangeDestination(int trackingId)
        {
            using (var shippContext = new ShippingDbContext())
            {
                var cargo = shippContext.Cargos.Where(c => c.TrackingId == trackingId).Single();

                var newDestination = shippContext.Locations.Single(l => l.PortCode == "Hoboken");

                cargo.ChangeDeliveryGoal(new DeliverySpecification(new DateTime(2025, 1, 1), newDestination.LocationId));
            }

        }

    }
}
