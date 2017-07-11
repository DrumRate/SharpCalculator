using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ExponentialFunctionTwoCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Pow(2, argument);
        }
    }
}