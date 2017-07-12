using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class SubstractionCalculatorTests
    {
        [TestCase(3, 6, -3)]
        [TestCase(21, 4, 17)]
        [TestCase(7, 0, 7)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new SubstractionCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}