using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function calculates the log to base e
    /// </summary>
    public class LnCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method calculates the log to base e
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument <= 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Log(argument, Math.E);
        }
    }
}
