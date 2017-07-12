using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    ///     Function wich rases exponent in a given degree
    /// </summary>
    public class ExpCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        ///     The method calculates the exponent in a given degree
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Exp(argument);
        }
    }
}