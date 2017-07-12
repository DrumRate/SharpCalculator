using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}