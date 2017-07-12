using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class RadialSystemRadiusCalculatorTests
    {
        [TestCase(1, 1, 1.414)]
        [TestCase(-3, 2, 3.606)]
        [TestCase(0, 12, 12)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new RadialSystemRadiusCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}