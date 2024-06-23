using Domain.Aggrgates.LocationAggregate;
using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CarrierMovementAggregate
{
    public class CarrierMovement(int scheduleId, Location fromLocation, Location toLocation) 
        : RootEntity
    {
        private readonly int _scheduleId = scheduleId;

        public int ScheduleId => _scheduleId;
        public Location FromLocation { get; private set; } = fromLocation;
        public Location ToLocation { get; private set; } = toLocation;
        
        public void LoadOnto(Location fromLocation, Location toLocation)
        {
            FromLocation = fromLocation;
            ToLocation = toLocation;
        }
    }
}
