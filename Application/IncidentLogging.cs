using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CarrierMovementAggregate;
using Domain.Aggrgates.HandlingIncidentAggregate;

namespace Application
{
    public class IncidentLogging
    {            
        public void LogHandlingEvent()
        {
            var cargo = new CargoRepository().FindByTrackingId(1);

            // Create handling incident Id
            var handlingIncident = new HandlingEvent(cargo, DateTime.Now, HandlingEvenType.Load);

            var carrierMovement = new CarrierMovementRepository().FindByScheduleId(1);
            handlingIncident.Load(carrierMovement);            
        }
    }
}
