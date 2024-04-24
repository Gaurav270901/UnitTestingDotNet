using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    internal class CustomerControllerTests
    {
        private CustomerController customer;

        [SetUp]
        public void SetUp()
        {
            customer = new CustomerController();

        }


        [Test]
        public void GetCustomer_IdIsZero_ReturnsNotFound()
        {
            var result = customer.GetCustomer(0);
            Assert.That(result, Is.TypeOf<NotFound>());//will work if returntype is not found
            Assert.That(result , Is.InstanceOf<NotFound>());//will work also for NotFound child classes
        }


        [Test]
        public void GetCustomer_IdIsNotZero_ReturnsOk()
        {
            var result = customer.GetCustomer(10);
            Assert.That(result, Is.TypeOf<Ok>());
        }


    }
}
