using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CustomerAggregate;
using Domain.Aggrgates.HandlingEventAggregate;
using Domain.Aggrgates.HandlingIncidentAggregate;
using Domain.Aggrgates.LocationAggregate;
using Infrastructure.Persistency;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTests
{
    public class ShippingTest
    {
        protected Cargo Cargo { get; set; } = null!;

        [SetUp]
        public void SetUp()
        {
            CleanUp();
            Arrange();
        }

        private void Arrange()
        {
            // Arrange
            using (var shippContext = new ShippingDbContext())
            {
                var customer = new CustomerFactory()
                    .CreateCustomer("Cargo Care");
                shippContext.Customers.Add(customer);
                shippContext.SaveChanges();

                var location = new LocationFactory()
                    .CreateLocation("VenloB2");
                shippContext.Locations.Add(location);
                shippContext.SaveChanges();

                Cargo = new CargoFactory(shippContext)
                    .CreateCargo(customer, 
                    new DeliverySpecification(new DateTime(2025,1, 1), location.LocationId));
                shippContext.Cargos.Add(Cargo);
                shippContext.SaveChanges();

                var handlingEvent = new HandlingEventFactory(shippContext)
                    .CreateHandlingEvent(Cargo, new DateTime(2024, 1,1), HandlingEventType.Load);
                shippContext.HandlingEvents.Add(handlingEvent);
                shippContext.SaveChanges();
            }
        }

        public void CleanUp()
        {
            // Clean up the database
            using (var shippContext = new ShippingDbContext())
            {
                shippContext.Database.ExecuteSql($"delete from Customers");
                shippContext.Database.ExecuteSql($"delete from Cargos");
                shippContext.Database.ExecuteSql($"delete from CarrierMovements");
                shippContext.Database.ExecuteSql($"delete from Locations");
                shippContext.Database.ExecuteSql($"delete from HandlingEvents");

            }
        }
    }
}
