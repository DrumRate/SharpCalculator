using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function which raises two to a given degree
    /// </summary>
    public class ExponentialFunctionTwoCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method which raises two to a given degree
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Pow(2, argument);
        }
    }
}