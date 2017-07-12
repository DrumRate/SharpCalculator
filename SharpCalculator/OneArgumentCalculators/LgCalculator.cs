using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function calculates the logarithm to the base ten
    /// </summary>
    public class LgCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method calculates the logarithm to the base ten
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument <= 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Log10(argument);
        }
    }
}