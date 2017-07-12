using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function which raises ten to a given degree
    /// </summary>
    public class ExponentialFunctionTenCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method which raises ten to a given degree
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            return Math.Pow(10, argument);
        }
    }
}