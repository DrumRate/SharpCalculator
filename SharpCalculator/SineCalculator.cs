using System;

namespace SharpCalculator
{
    public class SineCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}