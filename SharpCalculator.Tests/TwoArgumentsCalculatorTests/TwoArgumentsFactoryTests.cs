using System;
using NUnit.Framework;
using SharpCalculator.TwoArgumentsCalculators;

namespace SharpCalculator.Tests.TwoArgumentsCalculatorTests
{
    [TestFixture]
    public class TwoArgumentsFactoryTests
    {
        [TestCase("maximum", typeof(MaxCalculator))]
        [TestCase("arith", typeof(ArithmeticCalculator))]
        [TestCase("remain", typeof(RemainderCalculator))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}