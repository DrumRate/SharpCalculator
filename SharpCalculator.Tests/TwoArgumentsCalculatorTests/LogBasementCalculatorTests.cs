using System;
using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class LogBasementCalculatorTests
    {
        [TestCase(3, 9, 2)]
        [TestCase(21, 1, 0)]
        [TestCase(7, 7, 1)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new LogBasementCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new LogBasementCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(1, 0));
        }
    }
}