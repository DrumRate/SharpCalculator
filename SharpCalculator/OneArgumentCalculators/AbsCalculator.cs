using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class AbsCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}