using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class MaxCalculatorTests
    {
        [TestCase(3, 6, 6)]
        [TestCase(21, 4, 21)]
        [TestCase(7, 7, 7)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new MaxCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}