using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CarrierMovementAggregate;
using Domain.Aggrgates.HandlingIncidentAggregate;
using Infrastructure.Persistency;

namespace Application
{
    public class IncidentLoggingAppService
    {            
        public void LogHandlingEvent(int trackingId)
        {
            using (var shippContext = new ShippingDbContext())
            {
                var cargo = shippContext.Cargos.Single(c => c.TrackingId == trackingId);

                // Create handling incident Id
                var handlingIncident = new HandlingEvent(cargo, DateTime.Now, HandlingEventType.Load);

                var carrierMovement = shippContext.CarrierMovements.Single(m => m.ScheduleId == 1);
                handlingIncident.Load(carrierMovement);
            }
        }
    }
}
