using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    public class RadialSystemAngleCalculator : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument > 0 & secondArgument >= 0)
                return Math.Atan2(firstArgument, secondArgument);
            else if (firstArgument > 0 & secondArgument < 0)
                return Math.Atan2(firstArgument, secondArgument) + 2 * Math.PI;
            else if (firstArgument < 0)
                return Math.Atan2(firstArgument, secondArgument) + Math.PI;
            else if (firstArgument.Equals(0))
            {
                if (secondArgument > 0)
                    return Math.PI / 2;
                else if (secondArgument < 0)
                    return 3 * Math.PI / 2;
                else
                    throw new Exception("Значение не существует");
            }
            throw new Exception("Непредвиденная ошибка");
        }
    }
}