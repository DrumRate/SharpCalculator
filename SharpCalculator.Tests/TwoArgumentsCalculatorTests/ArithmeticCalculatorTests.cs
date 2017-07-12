using System;
using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class DoubleExponentinalCalculatorTests
    {
        [TestCase(2, 3, 2.5)]
        [TestCase(-4, -6, -5)]
        [TestCase(5, 3.4, 4.2)]
        public void CalculateTest(double firstArgument, double secondArgument, double expectedResult)
        {
            var calculator = new ArithmeticCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
    
}
