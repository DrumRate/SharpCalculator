using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class IntegerCalculatorTests
    {
        [TestCase(3, 6, 0)]
        [TestCase(21, 4, 5)]
        [TestCase(7, 3, 2)]
        public void CalculateTest(double firstAgrument, double secondArgument, double expectedResult)
        {
            var calculator = new IntegerCalculator();
            var actualResult = calculator.Calculate(firstAgrument, secondArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
        [Test]
        public void ExceptionTest()
        {
            var calculator = new IntegerCalculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Calculate(1, 0));
        }
    }
}