using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ArcSineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Asin(argument);
        }
    }
}