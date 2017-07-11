using System;

namespace SharpCalculator
{
    public class ArctanCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Atan(argument);
        }
    }
}