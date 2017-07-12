using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class ArithmeticCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument) / 2;
        }
    }
}