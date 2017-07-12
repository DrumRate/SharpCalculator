using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class DoubleExponentinalCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new ArithmeticCalculator();
            Assert.AreEqual(2.5, calculator.Calculate(2, 3));
            Assert.AreEqual(0, calculator.Calculate(-3, 3));
        }
    }
    
}
