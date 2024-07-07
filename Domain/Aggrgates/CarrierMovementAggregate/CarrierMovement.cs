using Domain.Aggrgates.LocationAggregate;
using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CarrierMovementAggregate
{
    public class CarrierMovement 
        : RootEntity
    {
        // Needed for EF
        private CarrierMovement() : this(0, null!, null!) {}

        internal CarrierMovement(int scheduleId, Location fromLocation, Location toLocation)
        {
            _scheduleId = scheduleId;
            FromLocation = fromLocation;
            ToLocation = toLocation;
        }

        private readonly int _scheduleId;

        public int ScheduleId => _scheduleId;
        public Location FromLocation { get; private set; }
        public Location ToLocation { get; private set; }
        
        public void LoadOnto(Location fromLocation, Location toLocation)
        {
            FromLocation = fromLocation;
            ToLocation = toLocation;
        }
    }
}
