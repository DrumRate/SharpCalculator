using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    ///     Function of the radius calculation point defined in the Euclidean radial coordinate system
    /// </summary>
    public class RadialSystemRadiusCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        ///     Method of the radius calculation point defined in the Euclidean radial coordinate system
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument * firstArgument + secondArgument * secondArgument, 0.5);
        }
    }
}