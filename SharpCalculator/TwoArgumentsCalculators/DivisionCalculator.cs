using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument.Equals(0))
                throw new DivideByZeroException();
            return firstArgument / secondArgument;
        }
    }
}
