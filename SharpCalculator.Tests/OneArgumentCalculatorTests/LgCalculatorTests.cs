using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class LgCalculatorTests
    {
        [TestCase(100, 2)]
        [TestCase(0.01, -2)]
        [TestCase(1, 0)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new LgCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new LgCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-10));
        }
    }
}