using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ArcSineGradCalculatorTests
    {
        [TestCase(1, 90)]
        [TestCase(-1, -90)]
        [TestCase(-0.25, -14.478)]
        public void CalculateTest(double firstAgrument, double expectedResult)
        {
            var calculator = new ArcSineGradCalculator();
            var actualResult = calculator.Calculate(firstAgrument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new ArcSineGradCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(2));
        }
    }
}