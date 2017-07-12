using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    ///     Function returns the inverse of the argument
    /// </summary>
    public class ReversiveCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        ///     Method returns the inverse of the argument
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument.Equals(0))
                throw new DivideByZeroException();
            return 1 / argument;
        }
    }
}