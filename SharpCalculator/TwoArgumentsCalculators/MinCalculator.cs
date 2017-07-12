using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class MinCalculator : ITwoArgumentsCalculator

    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);

        }
    }
}