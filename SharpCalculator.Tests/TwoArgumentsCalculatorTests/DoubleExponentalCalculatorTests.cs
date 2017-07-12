using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class DoubleExponentalCalculatorTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(-4, 2, 16)]
        [TestCase(5, 3, 125)]
        public void CalculateTest(double firstArgument, double secondArgument, double expectedResult)
        {
            var calculator = new DoubleExponentalCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }

}
