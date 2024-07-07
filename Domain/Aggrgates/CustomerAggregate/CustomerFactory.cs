using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CustomerAggregate
{
    public class CustomerFactory
    {
        public Customer CreateCustomer(string name)
        {
            var customer = new Customer(name);
            return customer;
        }
    }
}
