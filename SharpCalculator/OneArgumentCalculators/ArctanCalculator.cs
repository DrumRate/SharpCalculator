using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ArctanCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}