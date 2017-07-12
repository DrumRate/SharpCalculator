using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    /// Function of calculating the remainder from dividing the first argument by the second argument
    /// </summary>
    public class RemainderCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Method of calculating the remainder from dividing the first argument by the second argument
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.IEEERemainder (firstArgument, secondArgument);
        }
    }
}