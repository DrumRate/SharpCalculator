using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class LogBasementCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument <= 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Log(secondArgument, firstArgument);
        }
    }
}