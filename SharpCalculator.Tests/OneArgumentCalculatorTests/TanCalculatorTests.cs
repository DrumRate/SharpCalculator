using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    public class TanCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI / 4, 1)]
        [TestCase(3 * Math.PI / 4, -1)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new TanCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}