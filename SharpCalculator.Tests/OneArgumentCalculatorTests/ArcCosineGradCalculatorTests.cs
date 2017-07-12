using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ArcCosineGradCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(-1, 180)]
        [TestCase(-0.25, 104.478)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new ArcCosineGradCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new ArcCosineGradCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(2));
        }
    }

}
