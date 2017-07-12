using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    ///     Function integer division
    /// </summary>
    public class IntegerCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        ///     Method integer division
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument.Equals(0))
                throw new DivideByZeroException();
            return Math.Floor(firstArgument / secondArgument);
        }
    }
}