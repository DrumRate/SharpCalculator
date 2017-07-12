using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;
using SharpCalculator.TwoArgumentsCalculators;

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
    }

}
