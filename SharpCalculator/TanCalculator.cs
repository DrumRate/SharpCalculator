using System;

namespace SharpCalculator
{
    public class TanCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}