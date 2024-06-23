using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.LocationAggregate
{
    public class Location(int locationId, string portCode) : RootEntity
    {
        private readonly int _locationId = locationId;
        private readonly string _portCode = portCode;
        public string PortCode => _portCode;
        public int LocationId => _locationId;
    }
}
