using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CustomerAggregate;
using Domain.Aggrgates.LocationAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Booking
    {
        public void CreateCargo()
        {
            var customer = new CustomerRepository().FindByName("Cargo Care");
            var destination = new LocationRepository().FindByPortCode("VenloB2");

            new Cargo(1, customer.CustomerId, 
                new DeliverySpecification(new DateTime(2025, 1,1), destination.LocationId));
        }

        public void ChangeDestination()
        {
            var cargo = new CargoRepository().FindByTrackingId(1);
            var newDestination = new LocationRepository().FindByPortCode("Hoboken");

            cargo.ChangeDeliveryGoal(new DeliverySpecification(new DateTime(2025, 1, 1), newDestination.LocationId));
        }

    }
}
