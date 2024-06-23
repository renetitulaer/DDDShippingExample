using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CustomerAggregate
{
    public class CustomerRepository
    {
        public Customer FindByName(string name)
        {
            return new Customer(1, name);
        }
    }
}
