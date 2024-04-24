using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    internal class MathTests
    {
        private Fundamentals.Math math;
        [SetUp]
        public void SetUp() {  math = new Fundamentals.Math();}

        [Test]
        
        public void Add_WhenCalled_GreaterNumber()
        {
            

            var result = math.Add(1,2);

            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 3, 3)]
        [TestCase(4, 4, 4)]
        public void Max_FirstArgumentGreater_ReturnFirst(int a , int b , int expected)
        {
            var result = math.Max(a,b);
            Assert.That(result,Is.EqualTo(expected));
        }

        [Test]
        public void Max_SecondArgumentGreater_ReturnSecond()
        {
            var result = math.Max(11, 22);
            Assert.That(result, Is.EqualTo(22));
        }

        [Test]
        public void Max_BothAreEqual_ReturnSame()
        {
            var result = math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
