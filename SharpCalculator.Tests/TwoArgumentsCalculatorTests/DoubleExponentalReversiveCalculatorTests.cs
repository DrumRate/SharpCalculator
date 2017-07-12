using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class DoubleExponentalReversiveCalculatorTests
    {
        [TestCase(1, 2, 1)]
        [TestCase(16, 4, 2)]
        [TestCase(8, 3, 2)]
        public void CalculateTest(double firstArgument, double secondArgument, double expectedResult)
        {
            var calculator = new DoubleExponentalReversiveCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }

}
