using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class DoubleExponentalCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}