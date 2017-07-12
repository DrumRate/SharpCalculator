using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class IntegerCalculator : ITwoArgumentsCalculator

    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Floor(firstArgument / secondArgument);
        }
    }
}