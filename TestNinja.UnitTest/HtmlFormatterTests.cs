using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    internal class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEnclosedStringWithBoldElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("Gaurav");

            Assert.That(result, Is.EqualTo("<strong>Gaurav</strong>"));
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("Gaurav"));

        }
    }
}
