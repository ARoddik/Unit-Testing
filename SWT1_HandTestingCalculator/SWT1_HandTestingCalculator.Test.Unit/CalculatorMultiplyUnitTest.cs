using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SWT1_HandTestingCalculator.Test.Unit
{
    [TestFixture]
    class CalculatorMultiplyUnitTest
    {
        [Test]
        public void TestMultiply_8And7_Returns56()
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(8, 7), Is.EqualTo(56));
        }

        [Test]
        public void TestMultiply_9AndMinus4_ReturnsMinus36()
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(9, -4), Is.EqualTo(-36));
        }

        [Test]
        public void TestMultiply_5Point8And10Point2_Returns59Point16()
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(5.8, 10.2), Is.EqualTo(59.16));
        }
    }
}
