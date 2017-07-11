using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class TanCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}