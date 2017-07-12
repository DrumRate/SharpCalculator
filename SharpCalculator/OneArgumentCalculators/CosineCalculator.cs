using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    ///     The function calculates the cosine of a number
    /// </summary>
    public class CosineCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        ///     The method calculates the cosine of a number
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}