using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CustomerAggregate
{
    public class Customer : RootEntity
    {
        // Needed for EF
        private Customer() : this(string.Empty) {}

        internal Customer(string name)
        {
            _name = name;
        }
        private readonly int _customerId;
        
        private string _name;

        public int CustomerId => _customerId;
        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public void ChangeName(string name)
        {
            _name = name;
        }
    }
}
