using NUnit.Framework;
using NUnit.Framework.Internal;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class MultiplyCalculatorTests
    {
        [TestCase(3, 6, 18)]
        [TestCase(21, 4, 84)]
        [TestCase(7, -7, -49)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new MultiplyCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}