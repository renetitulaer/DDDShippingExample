//using Domain.Aggrgates.CargoAggregate;
//using Domain.Aggrgates.CarrierMovementAggregate;
//using Domain.Aggrgates.HandlingIncidentAggregate;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Domain.Aggrgates.HandlingEventAggregate
//{
//    public class HandlingEventRepository
//    {
//        private IEnumerable<HandlingEvent> _allHandlingEvents = new List<HandlingEvent>();

//        public IEnumerable<HandlingEvent> FindByTrackingId(int trackingId)
//        {
//            return _allHandlingEvents.Where(x => x.Loaded.TrackingId == trackingId).ToList();
//        }
//        public IEnumerable<HandlingEvent> FindByDate(DateTime date)
//        {
//            return _allHandlingEvents.Where(x => x.TimeStamp.Date == date).ToList();
//        }

//        public IEnumerable<HandlingEvent> FindByScheduleId(int scheduleId)
//        {
//            return _allHandlingEvents.Where(x => x.LoadedOnto != null && 
//                x.LoadedOnto.ScheduleId == scheduleId)
//                .ToList();
//        }

//    }
//}
