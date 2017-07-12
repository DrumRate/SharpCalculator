using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ExponentialFunctionTwoCalculatorTests
    {
        [TestCase(2, 4)]
        [TestCase(0, 1)]
        [TestCase(3, 8)]
        public void CalculateTest(double firstArgument, double expectedAnswer)
        {
            var calculator = new ExponentialFunctionTwoCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedAnswer, actualResult, 0.001);
        }
    }
}