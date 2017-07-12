using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class SquareCalculatorTests
    {
        [TestCase(2, 4)]
        [TestCase(-4, 16)]
        [TestCase(-3.5, 12.25)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new SquareCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}