using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class CosineCalculatorTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI/2, 0)]
        [TestCase(Math.PI, -1)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new CosineCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}