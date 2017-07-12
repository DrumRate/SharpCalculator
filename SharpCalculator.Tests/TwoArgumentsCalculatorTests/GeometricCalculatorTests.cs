using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class GeometricCalculatorTests
    {
        [TestCase(4, 4, 4)]
        [TestCase(25, 1, 5)]
        [TestCase(0, 0, 0)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new GeometricCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}