using System;

namespace SharpCalculator
{
    public class CtanCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return 1 / Math.Tan(argument);
        }
    }
}