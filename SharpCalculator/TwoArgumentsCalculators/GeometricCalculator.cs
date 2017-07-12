using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class GeometricCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Sqrt(firstArgument * secondArgument);
        }
    }
}