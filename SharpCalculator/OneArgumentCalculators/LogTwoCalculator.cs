using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class LogTwoCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument, 2);
        }
    }
}
