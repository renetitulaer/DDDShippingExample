using Domain.Persistency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SeedWork
{
    public interface IInjectServiceProvider
    {
        IShippingDbContext ShippingDbContext { get; set; }
    }
}
