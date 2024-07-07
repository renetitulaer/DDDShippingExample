using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistency
{
    public class ShippingDbContextFactory : IDesignTimeDbContextFactory<ShippingDbContext>

    {
        public ShippingDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShippingDbContext>();

            if (args.Any())
                optionsBuilder.UseSqlServer(args[0]);

            return new ShippingDbContext(//optionsBuilder.Options
                                         );
        }
    }
}
