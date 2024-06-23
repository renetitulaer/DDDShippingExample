using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.CarrierMovementAggregate;
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
        private readonly int _handlingIncidentId;
        private readonly HandlingEvenType _type;
        private readonly DateTime _timeStamp;
        private readonly CarrierMovement? _loadedOnto;
        private readonly Cargo _loaded;

        public int HandlingIncidentId => _handlingIncidentId;
        public DateTime TimeStamp => _timeStamp;
        public HandlingEvenType Type => _type;
        public CarrierMovement? LoadedOnto => _loadedOnto;
        public Cargo Loaded => _loaded;

        public HandlingEvent(Cargo loaded, CarrierMovement? loadedOnto, 
            DateTime timeStamp, HandlingEvenType type)
        {
            _handlingIncidentId = CreateId();
            _loaded = loaded;
            _loadedOnto = loadedOnto;
            _timeStamp = timeStamp;
            _type = type;
        }

        public HandlingEvent(Cargo cargo, DateTime timeStamp, HandlingEvenType type) 
            : this(cargo, null, timeStamp, type)
        {
        }

        public void Load(CarrierMovement carrierMovement)
        {
            carrierMovement.LoadOnto(carrierMovement.FromLocation, carrierMovement.ToLocation);
        }

        private int CreateId()
        {
            return new Random().Next();
        }
    }
}
