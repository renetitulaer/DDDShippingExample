using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.LocationAggregate
{
    public class LocationFactory
    {
        public Location CreateLocation(string name)
        {
            return new Location(name);
        }
    }
}
