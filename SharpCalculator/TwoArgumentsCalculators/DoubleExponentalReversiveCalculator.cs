using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class DoubleExponentalReversiveCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument.Equals(0))
                throw new DivideByZeroException();
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}