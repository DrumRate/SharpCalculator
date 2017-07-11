using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ExponentialFunctionTenCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Pow(10, argument);
        }
    }
}