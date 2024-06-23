using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.CargoAggregate
{
    /// <summary>
    /// Value object.
    /// Cannot be updated (?). If something changes, a new one must be created (?).
    /// </summary>
    /// <param name="arrivelTime"></param>
    /// <param name="destinationId"></param>
    public class DeliverySpecification(DateTime arrivelTime, int destinationId) : ValueObject
    {
        private readonly DateTime _arrivelTime = arrivelTime;
        private readonly int _destinationId = destinationId;
        public DateTime ArrivelTime => _arrivelTime;
        public int DestinationId => _destinationId;
    }
}
