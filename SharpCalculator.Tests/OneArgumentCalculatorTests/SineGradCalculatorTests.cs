using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    public class SineGradCalculatorTests
    {
        [TestCase(180, 0)]
        [TestCase(90, 1)]
        [TestCase(0, 0)]
        public void CalculateTest(double firstArgument, double expectedResult)
        {
            var calculator = new SineGradCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}