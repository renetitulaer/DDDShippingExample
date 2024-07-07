using Domain.Aggrgates.HandlingIncidentAggregate;
using Infrastructure.Persistency;

namespace Application
{
    public class TrackingAppService
    {
        public IEnumerable<HandlingEvent> GetDeliveryHistory(int trackingId)
        {
            using (var shippContext = new ShippingDbContext())
            {
                var cargo = shippContext.Cargos.Where(c => c.TrackingId == trackingId).Single();
                return cargo.GetDeliveryHistory();
            }
        }
    }
}
