using System;

namespace SharpCalculator
{
    public class ReversiveCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return 1 / argument;
        }
    }
}