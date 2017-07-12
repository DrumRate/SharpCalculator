using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class AdditionCalculatorTests
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new AdditionCalculator();
            Assert.AreEqual(5, calculator.Calculate(2, 3));
            Assert.AreEqual(0, calculator.Calculate(-3, 3));
        }
    }

}
