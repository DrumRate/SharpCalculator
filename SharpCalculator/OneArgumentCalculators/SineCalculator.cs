using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function to compute the sine
    /// </summary>
    public class SineCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method to compute the sine
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}