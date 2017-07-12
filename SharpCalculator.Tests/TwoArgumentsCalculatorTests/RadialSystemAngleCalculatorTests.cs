using System;
using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class RadialSystemAngleCalculatorTests
    {
        [TestCase(1, 1, 0.785)]
        [TestCase(-3, 2, 2.159)]
        [TestCase(0, 12, Math.PI / 2)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new RadialSystemAngleCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new RadialSystemAngleCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(0, 0));
        }
    }
}