using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class CtanCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return 1 / Math.Tan(argument);
        }
    }
}