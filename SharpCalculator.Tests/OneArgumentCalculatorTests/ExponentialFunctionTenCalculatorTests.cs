using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ExponentialFunctionTenCalculatorTests
    {
        [TestCase(2, 100)]
        [TestCase(0, 1)]
        [TestCase(0.5, 3.162)]
        public void CalculateTest(double firstArgument, double expectedAnswer)
        {
            var calculator = new ExponentialFunctionTenCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedAnswer, actualResult, 0.001);
        }
    }
}