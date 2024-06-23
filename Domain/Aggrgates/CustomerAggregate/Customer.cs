using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CustomerAggregate
{
    public class Customer(int customerId, string name) : RootEntity
    {
        private readonly int _customerId = customerId;
        
        private string _name = name;

        public int CustomerId => _customerId;
        public string Name => _name;

        public void ChangeName(string name)
        {
            _name = name;
        }
    }
}
