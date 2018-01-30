using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SWT1_HandTestingCalculator.Test.Unit
{
    [TestFixture]
    class CalculatorCompleteUnitTest
    {
        // Test Add method from Calculator with 3 different sets of values
        [Test]
        [TestCase(10, 5, 15)]
        [TestCase(-10, 5, -5)]
        [TestCase(25.5, 17.7, 43.2)]
        public void TestAdd(double a, double b, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Add(a, b), Is.EqualTo(result));
        }

        // Test Subtract method from Calculator with 3 different sets of values
        [Test]
        [TestCase(20, 19, 1)]
        [TestCase(-20, 19, -39)]
        [TestCase(29.5, 14.5, 15)]
        public void TestSubtract(double a, double b, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(a, b), Is.EqualTo(result));
        }

        // Test Multiply method from Calculator with 3 different sets of values
        [Test]
        [TestCase(8, 7, 56)]
        [TestCase(9, -4, -36)]
        [TestCase(5.8, 10.2, 59.16)]
        public void TestMultiply(double testValue1, double testValue2, double testValue3)
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(testValue1, testValue2), Is.EqualTo(testValue3));
        }

        // Test Power method from calculator with 2 different sets of values
        [Test]
        [TestCase(10, 2, 100)]
        [TestCase(10, -1, 0.1)]
        public void TestPower(double a, double b, double result)
        {
            var uut = new Calculator();

            Assert.That(uut.Power(a, b), Is.EqualTo(result));
        }

    }
}
