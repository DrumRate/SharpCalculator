using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ArctanCalculatorTests
    {
        [TestCase(1, Math.PI / 4)]
        [TestCase(-1, -Math.PI / 4)]
        [TestCase(0, 0)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new ArctanCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}