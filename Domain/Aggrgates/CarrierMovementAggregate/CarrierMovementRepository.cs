//using Domain.Aggrgates.LocationAggregate;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Domain.Aggrgates.CarrierMovementAggregate
//{
//    public class CarrierMovementRepository
//    {
//        public CarrierMovement FindByScheduleId(int scheduleId)
//        {
//            return new CarrierMovement(scheduleId, 
//                new Location("AmsterdamA1"), new Location("VenloB2"));
//        }

//        public CarrierMovement FindByFromLocation(string portName)
//        {
//            return new CarrierMovement(1,
//                new Location(portName), new Location("VenloB2"));
//        }

//        public CarrierMovement FindByToLocation(string portName)
//        {
//            return new CarrierMovement(1,
//                new Location("AmsterdamA1"), new Location(portName));
//        }
//    }
//}
