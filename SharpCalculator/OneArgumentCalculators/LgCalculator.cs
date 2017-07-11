using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class LgCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Log10(argument);
        }
    }
}