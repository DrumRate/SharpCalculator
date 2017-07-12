using System;
using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class DivisionCalculatorTests
    {
        [TestCase(1, 2, 0.5)]
        [TestCase(-3, 2, -1.5)]
        [TestCase(21, 1, 21)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new DivisionCalculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Calculate(1, 0));
        }
    }
}