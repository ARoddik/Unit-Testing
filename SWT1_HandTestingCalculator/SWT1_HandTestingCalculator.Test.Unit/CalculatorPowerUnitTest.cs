using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SWT1_HandTestingCalculator.Test.Unit
{
    [TestFixture]
    class CalculatorPowerUnitTest
    {
        [Test]
        public void TestPower_10And2_Returns100()
        {
            var uut = new Calculator();

            Assert.That(uut.Power(10, 2), Is.EqualTo(100));
        }

        [Test]
        public void TestPower_10AndMinus1_Returns0Point1()
        {
            var uut = new Calculator();

            Assert.That(uut.Power(10, -1), Is.EqualTo(0.1));
        }
    }
}
