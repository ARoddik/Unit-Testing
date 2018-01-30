using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SWT1_HandTestingCalculator.Test.Unit
{
    [TestFixture]
    class CalculatorSubtractUnitTest
    {
        [Test]
        public void TestSubtract_20And19_Returns1()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(20, 19), Is.EqualTo(1));
        }

        [Test]
        public void TestSubtract_Minus20And19_ReturnsMinus39()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(-20, 19), Is.EqualTo(-39));
        }

        [Test]
        public void TestSubtract_29Point5And14Point5_Returns15()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(29.5, 14.5), Is.EqualTo(15));
        }
    }
}
