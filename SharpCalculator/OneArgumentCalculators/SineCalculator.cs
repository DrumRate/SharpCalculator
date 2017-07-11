using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class SineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}