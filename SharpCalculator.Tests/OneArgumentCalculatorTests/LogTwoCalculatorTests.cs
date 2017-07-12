using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class LogTwoCalculatorTests
    {
        [TestCase(4, 2)]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new LogTwoCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new LogTwoCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-10));
        }
    }
}