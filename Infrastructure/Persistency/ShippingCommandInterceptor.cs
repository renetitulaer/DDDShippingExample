using Domain.Persistency;
using Domain.SeedWork;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure.Persistency
{
    public class ShippingCommandInterceptor : IMaterializationInterceptor
    {
        public object InitializedInstance(MaterializationInterceptionData materializationData, object instance)
        {
            if (instance is IInjectServiceProvider entity)
            {
                if (materializationData.Context != null)
                { 
                    if (materializationData.Context is IShippingDbContext shippingContext)
                    {
                        entity.ShippingDbContext = shippingContext;
                    }
                }
            }
            return instance;
        }
    }
}