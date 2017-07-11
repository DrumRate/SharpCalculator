using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ArcCosineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Acos(argument);
        }
    }
}