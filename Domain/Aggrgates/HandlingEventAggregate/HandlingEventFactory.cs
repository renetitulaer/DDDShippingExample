using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CarrierMovementAggregate;
using Domain.Aggrgates.HandlingIncidentAggregate;
using Domain.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.HandlingEventAggregate
{
    public class HandlingEventFactory(IShippingDbContext shippingDbContext)
    {
        public HandlingEvent CreateHandlingEvent(Cargo cargo, CarrierMovement? carrierMovement, DateTime timeStamp, HandlingEventType type)
        {
            var handlingEvent =  new HandlingEvent(cargo, carrierMovement, timeStamp, type);
            handlingEvent.ShippingDbContext = shippingDbContext;
            return handlingEvent;
        }

        public HandlingEvent CreateHandlingEvent(Cargo cargo, DateTime timeStamp, HandlingEventType type) 
        {
            return CreateHandlingEvent(cargo, null, timeStamp, type);
        }
    }
}
