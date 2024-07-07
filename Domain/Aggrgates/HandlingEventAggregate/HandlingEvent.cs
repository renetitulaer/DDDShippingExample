using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CarrierMovementAggregate;
using Domain.Persistency;
using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.HandlingIncidentAggregate
{
    public class HandlingEvent 
        : RootEntity
    {
        internal IShippingDbContext? ShippingDbContext { get; set; }

        private readonly HandlingEventType _type;
        private readonly DateTime _timeStamp;
        private readonly CarrierMovement? _loadedOnto;
        private readonly int _trackingId;

        public DateTime TimeStamp => _timeStamp;
        public HandlingEventType Type => _type;
        public CarrierMovement? LoadedOnto => _loadedOnto;
        public Cargo Loaded => ShippingDbContext!.Cargos.Single(c => c.TrackingId == _trackingId);
        public int TrackingId => _trackingId;

        // Needed for EF
        private HandlingEvent() {}

        internal HandlingEvent(Cargo loaded, CarrierMovement? loadedOnto, 
            DateTime timeStamp, HandlingEventType type)
        {
            _trackingId = loaded.TrackingId;
            _loadedOnto = loadedOnto;
            _timeStamp = timeStamp;
            _type = type;
        }

        public HandlingEvent(Cargo cargo, DateTime timeStamp, HandlingEventType type) 
            : this(cargo, null, timeStamp, type)
        {
        }

        public void Load(CarrierMovement carrierMovement)
        {
            carrierMovement.LoadOnto(carrierMovement.FromLocation, carrierMovement.ToLocation
                                                                 );
        }
    }
}
