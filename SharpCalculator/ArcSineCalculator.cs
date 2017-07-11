using System;

namespace SharpCalculator
{
    public class ArcSineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Asin(argument);
        }
    }
}