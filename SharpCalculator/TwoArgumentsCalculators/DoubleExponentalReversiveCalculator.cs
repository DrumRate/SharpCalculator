using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class DoubleExponentalReversiveCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}