using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    ///     Function of calculating corner points, given in Euclidean coordinates into the radial coordinate system
    /// </summary>
    public class RadialSystemAngleCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        ///     Method of calculating corner points, given in Euclidean coordinates into the radial coordinate system
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if ((firstArgument > 0) & (secondArgument >= 0))
                return Math.Atan2(firstArgument, secondArgument);
            if ((firstArgument > 0) & (secondArgument < 0))
                return Math.Atan2(firstArgument, secondArgument) + 2 * Math.PI;
            if (firstArgument < 0)
                return Math.Atan2(firstArgument, secondArgument) + Math.PI;
            if (firstArgument.Equals(0))
                if (secondArgument > 0)
                    return Math.PI / 2;
                else if (secondArgument < 0)
                    return 3 * Math.PI / 2;
                else
                    throw new Exception("Значение не существует");
            throw new Exception("Непредвиденная ошибка");
        }
    }
}