using Domain.Aggrgates.LocationAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CarrierMovementAggregate
{
    public class CarrierMovementRepository
    {
        public CarrierMovement FindByScheduleId(int scheduleId)
        {
            return new CarrierMovement(scheduleId, 
                new Location(1, "AmsterdamA1"), new Location(2, "VenloB2"));
        }

        public CarrierMovement FindByFromLocation(string portName)
        {
            return new CarrierMovement(1,
                new Location(1, portName), new Location(2, "VenloB2"));
        }

        public CarrierMovement FindByToLocation(string portName)
        {
            return new CarrierMovement(1,
                new Location(1, "AmsterdamA1"), new Location(2, portName));
        }
    }
}
