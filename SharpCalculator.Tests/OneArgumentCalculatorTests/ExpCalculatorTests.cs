using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class ExpCalculatorTests
    {
        [TestCase(2, 7.389)]
        [TestCase(0, 1)]
        [TestCase(0.5, 1.649)]
        public void CalculateTest(double firstArgument, double expectedAnswer)
        {
            var calculator = new ExpCalculator();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(expectedAnswer, actualResult, 0.001);
        }
    }
}