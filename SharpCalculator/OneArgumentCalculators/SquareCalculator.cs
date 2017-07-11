using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class SquareCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return argument * argument;
        }
    }
}