using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class RadialSystemRadiusCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument * firstArgument + secondArgument * secondArgument, 0.5);
        }
    }
}