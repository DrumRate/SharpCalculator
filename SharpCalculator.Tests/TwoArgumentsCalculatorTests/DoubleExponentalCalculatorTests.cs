using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class DoubleExponentalCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new DoubleExponentalCalculator();
            Assert.AreEqual(8, calculator.Calculate(2, 3));
            Assert.AreEqual(-27, calculator.Calculate(-3, 3));
        }
    }

}
