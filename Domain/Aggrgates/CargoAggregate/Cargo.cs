using Domain.Aggrgates.CustomerAggregate;
using Domain.Aggrgates.HandlingIncidentAggregate;
using Domain.SeedWork;

namespace Domain.Aggrgates.CargoAggregate
{
    public class Cargo : RootEntity
    {
        private readonly int _trackingId;
        private readonly int _customerId;

        public Cargo(int trackingId,
            int customerId, DeliverySpecification deliveryGoal)
        {
            _trackingId = trackingId;
            _customerId = customerId;
            DeliveryHistory = new DeliveryHistory(this);
            DeliveryGoal = deliveryGoal;
        }

        
        public int TrackingId => _trackingId;
        public int CustomerId => _customerId;
        public DeliveryHistory DeliveryHistory { get; private set; } 
        public DeliverySpecification DeliveryGoal { get; private set; }
        public void ChangeDeliveryGoal(DeliverySpecification deliveryGoal)
        {
            DeliveryGoal = deliveryGoal;
        }
    }
}
