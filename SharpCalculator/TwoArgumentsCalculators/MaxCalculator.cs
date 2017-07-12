using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Function of comparing two numbers and output the maximum
    /// </summary>
    public class MaxCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Method of comparing two numbers and output the maximum
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}