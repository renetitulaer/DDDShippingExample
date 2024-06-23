using Domain.Aggrgates.CargoAggregate;
using Domain.Aggrgates.HandlingIncidentAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Tracking
    {
        public IEnumerable<HandlingEvent> GetDeliveryHistory()
        {
            var cargo = new CargoRepository().FindByTrackingId(1);
            return cargo.DeliveryHistory.HandlingIncidents;
        }
    }
}
