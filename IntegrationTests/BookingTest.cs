using Application;
using Domain.Aggrgates.CustomerAggregate;
using Domain.Aggrgates.LocationAggregate;
using Infrastructure.Persistency;
using Microsoft.EntityFrameworkCore;

namespace IntegrationTests
{
    public class BookingTest : ShippingTest
    {       
        [Test]
        public void CreateCargo()
        {

            var booking = new BookingAppService();
            booking.CreateCargo();

            Assert.Pass();
        }

        [Test]
        public void ChangeDestination()
        {
            var booking = new BookingAppService();
            booking.CreateCargo();
            booking.ChangeDestination(1);

            Assert.Pass();
        }
    }
}