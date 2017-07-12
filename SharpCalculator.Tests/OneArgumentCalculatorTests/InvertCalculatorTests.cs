using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class InvertCalculatorTests
    {
        [TestCase(1, -1)]
        [TestCase(-1, 1)]
        [TestCase(0.75, -0.75)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new InvertCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }

}
