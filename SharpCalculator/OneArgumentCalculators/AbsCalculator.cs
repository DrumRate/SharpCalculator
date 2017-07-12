using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// A function that computes the absolute value of
    /// </summary>
    public class AbsCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// A method that calculates the absolute value of
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Abs(argument);
        }
    }
}