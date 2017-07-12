using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ReversiveCalculatorTests
    {
        [TestCase(1, 1)]
        [TestCase(-5, -0.2)]
        [TestCase(-2, -0.5)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new ReversiveCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void ExceptionTest()
        {
            var calculator = new ReversiveCalculator();
            Assert.Throws<DivideByZeroException>(()=>calculator.Calculate(0));
        }
    }

}
