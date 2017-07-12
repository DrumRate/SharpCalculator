using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    ///     The function calculates the cotangent of a number
    /// </summary>
    public class CtanCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        ///     The method calculates the cotangent of a number
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return 1 / Math.Tan(argument);
        }
    }
}