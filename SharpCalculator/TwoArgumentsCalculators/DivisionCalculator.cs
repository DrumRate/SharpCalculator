using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    ///     Function subtraction of the two arguments
    /// </summary>
    public class DivisionCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        ///     Method subtraction of the two arguments
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument.Equals(0))
                throw new DivideByZeroException();
            return firstArgument / secondArgument;
        }
    }
}