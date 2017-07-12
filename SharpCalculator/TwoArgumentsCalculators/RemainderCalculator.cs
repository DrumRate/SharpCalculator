using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class RemainderCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.IEEERemainder (firstArgument, secondArgument);
        }
    }
}