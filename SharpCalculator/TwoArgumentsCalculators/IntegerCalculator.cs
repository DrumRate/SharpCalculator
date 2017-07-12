using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class IntegerCalculator : ITwoArgumentsCalculator

    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument.Equals(0))
                throw new DivideByZeroException();
            return Math.Floor(firstArgument / secondArgument);
        }
    }
}