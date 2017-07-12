using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    ///     Function to compute the logarithm of the first argument the base equal to the second argument
    /// </summary>
    public class LogBasementCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        ///     Method to compute the logarithm of the first argument the base equal to the second argument
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument <= 0)
                throw new Exception("Недопустимые входные данные");
            if (firstArgument <= 1)
                throw new Exception("Недопустимые входные данные");
            return Math.Log(secondArgument, firstArgument);
        }
    }
}