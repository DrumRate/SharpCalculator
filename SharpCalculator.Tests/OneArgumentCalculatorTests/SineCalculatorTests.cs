using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class SineCalculatorTests
    {
        [TestCase(Math.PI, 0)]
        [TestCase(Math.PI / 2, 1)]
        [TestCase(0, 0)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new SineCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}