using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //arrange 
            //arrange is where we initialize our objects
            var reservation = new Reservation();
            //act
            //where we act on object where we test our method
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true});

            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotAdmin_ReturnsFalse()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false});
            Assert.That(result,Is.False);

        }
    }
}
