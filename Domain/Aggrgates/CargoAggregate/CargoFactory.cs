using Domain.Aggrgates.CustomerAggregate;
using Domain.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CargoAggregate
{
    public class CargoFactory(IShippingDbContext shippingDbContext)
    {
        private readonly IShippingDbContext shippingDbContext = shippingDbContext;

        public Cargo CreateCargo(Customer customer, DeliverySpecification deliveryGoal)
        {
            var cargo = new Cargo(customer, deliveryGoal)
            {
                ShippingDbContext = shippingDbContext
            };
            return cargo;
        }
    }
}
