using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class LnCalculatorTests
    {
        [TestCase(Math.E * Math.E, 2)]
        [TestCase(1, 0)]
        [TestCase(Math.E, 1)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new LnCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new LnCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-10));
        }
    }
}