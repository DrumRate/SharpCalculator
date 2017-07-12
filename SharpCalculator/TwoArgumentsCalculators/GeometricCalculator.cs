using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class GeometricCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument + secondArgument < 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Sqrt(firstArgument * secondArgument);
        }
    }
}