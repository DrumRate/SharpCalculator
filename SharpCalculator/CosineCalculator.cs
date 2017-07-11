using System;

namespace SharpCalculator
{
    public class CosineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}