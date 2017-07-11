using System;

namespace SharpCalculator
{
    public class ArcCosineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Acos(argument);
        }
    }
}