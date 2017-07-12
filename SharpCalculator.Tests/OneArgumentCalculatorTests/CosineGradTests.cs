using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class CosineGradCalculatorTests
    {
        [TestCase(0, 1)]
        [TestCase(90, 0)]
        [TestCase(180, -1)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new CosineGradCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}