using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function calculates the log to base two
    /// </summary>
    public class LogTwoCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method calculates the log to base two
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument <= 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Log(argument, 2);
        }
    }
}
