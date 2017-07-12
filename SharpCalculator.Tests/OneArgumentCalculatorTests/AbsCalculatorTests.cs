using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class AbsCalculatorTests
    {
        [TestCase(2, 2)]
        [TestCase(-4, 4)]
        [TestCase(-3.5, 3.5)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new AbsCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }

}
