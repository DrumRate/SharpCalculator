using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ExpCalculator : IOneAgrumentsCalculator

    {
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}