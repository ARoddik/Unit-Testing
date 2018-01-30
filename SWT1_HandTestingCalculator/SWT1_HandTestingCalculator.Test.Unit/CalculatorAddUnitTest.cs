using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWT1_HandTestingCalculator;
using NUnit.Framework;

namespace SWT1_HandTestingCalculator.Test.Unit
{
    [TestFixture]

    public class CalculatorAddUnitTest
    {
        [Test]
        public void TestAdd_10And5_Returns15()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(10, 5), Is.EqualTo(15));
        }

        [Test]
        public void TestAdd_Minus10And5_ReturnsMinus5()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(-10, 5), Is.EqualTo(-5));
        }

        [Test]
        public void TestAdd_25Point5And17Point7_Returns43Point2()
        {
            var uut = new Calculator();

            Assert.That(uut.Add(25.5, 17.7), Is.EqualTo(43.2));
        }

        

    }
}
