using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class LnCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument, Math.E);
        }
    }
}
