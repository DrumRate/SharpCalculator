using System;

namespace SharpCalculator.OneArgumentCalculators
{
    public class ReversiveCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            if (argument.Equals(0))
                throw new DivideByZeroException();
            return 1 / argument;
        }
    }
}