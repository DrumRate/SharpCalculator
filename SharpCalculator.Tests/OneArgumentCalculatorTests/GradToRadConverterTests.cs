using System;
using NUnit.Framework;
using SharpCalculator.OneArgumentCalculators;

namespace SharpCalculator.Tests.OneArgumentCalculatorTests
{
    [TestFixture]
    public class GradToRadConverterTests
    {
        [TestCase(90, Math.PI / 2)]
        [TestCase(0, 0)]
        [TestCase(180, Math.PI)]
        public void ConvertTest(double firstArgument, double expectedResult)
        {
            var converter = new GradToRadConverter();
            var actualResult = converter.Calculate(firstArgument);
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}