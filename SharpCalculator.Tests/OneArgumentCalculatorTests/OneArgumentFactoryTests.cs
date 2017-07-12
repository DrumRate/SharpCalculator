using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class OneArgumentFactoryTests
    {
        [TestCase("abs", typeof(AbsCalculator))]
        [TestCase("exp", typeof(ExpCalculator))]
        [TestCase("lg", typeof(LgCalculator))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}