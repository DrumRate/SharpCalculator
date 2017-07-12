using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Function of geometric mean
    /// </summary>
    public class GeometricCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Method of geometric mean
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument + secondArgument < 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Sqrt(firstArgument * secondArgument);
        }
    }
}