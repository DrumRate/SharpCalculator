using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class CosineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}