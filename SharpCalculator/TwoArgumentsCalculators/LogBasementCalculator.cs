using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class LogBasementCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}