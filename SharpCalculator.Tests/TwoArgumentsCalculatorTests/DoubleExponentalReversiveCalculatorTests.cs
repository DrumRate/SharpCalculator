using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class DoubleExponentalReversiveCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new DoubleExponentalReversiveCalculator();
            Assert.AreEqual(2, calculator.Calculate(8, 3));
            Assert.AreEqual(3, calculator.Calculate(27, 3));
        }
    }

}
