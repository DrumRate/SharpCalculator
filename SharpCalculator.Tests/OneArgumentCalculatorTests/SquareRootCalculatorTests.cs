using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class SquareRootCalculatorTests
    {
        [TestCase(25, 5)]
        [TestCase(49, 7)]
        [TestCase(81, 9)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new SquareRootCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new SquareRootCalculator();
            Assert.Throws<Exception>(() => calculator.Calculate(-23));
        }
    }
}