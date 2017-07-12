using System;

namespace SharpCalculator.TwoArgumentsCalculators
{
    /// <summary>
    ///     Function of the construction of the first argument to the power equal to the reciprocal of the second argument
    /// </summary>
    public class DoubleExponentalReversiveCalculator : ITwoArgumentsCalculator
    {
        /// <summary>
        ///     Method of the construction of the first argument to the power equal to the reciprocal of the second argument
        /// </summary>
        /// <param name="firstArgument">Parametr that is entered by user</param>
        /// <param name="secondArgument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument.Equals(0))
                throw new DivideByZeroException();
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}