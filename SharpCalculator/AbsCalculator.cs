using System;

namespace SharpCalculator
{
    public class AbsCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}