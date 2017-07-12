using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ArcSineCalculatorTests
    {
        [TestCase(1, Math.PI / 2)]
        [TestCase(-1, -Math.PI / 2)]
        [TestCase(-0.25, -0.253)]
        public void CalculateTest(double firstAgrument, double expectedResult)
        {
            var calculator = new ArcSineCalculator();
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