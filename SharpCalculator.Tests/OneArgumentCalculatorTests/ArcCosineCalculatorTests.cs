using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ArcCosineCalculatorTests
    {
        [TestCase(1, 0)]
        [TestCase(-1, Math.PI)]
        [TestCase(-0.25, 1.823)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new ArcCosineCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new ArcCosineCalculator();
            Assert.Throws<Exception>(()=>calculator.Calculate(2));
        }
    }

}
