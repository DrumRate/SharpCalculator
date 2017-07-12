using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [TestCase(2, 3, 5)]
        [TestCase(-4, -6, -10)]
        [TestCase(5, 3.4, 8.4)]
        public void CalculateTest(double firstArgument, double secondArgument, double expectedResult)
        {
            var calculator = new AdditionCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }

}
