using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class CtanCalculatorTests
    {
        [TestCase(Math.PI / 4, 1)]
        [TestCase(-Math.PI / 4, -1)]
        [TestCase(Math.PI / 2, 0)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new CtanCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }

}
