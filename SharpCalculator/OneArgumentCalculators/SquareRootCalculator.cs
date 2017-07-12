using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function of the square root
    /// </summary>
    public class SquareRootCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method of the square root
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument < 0)
                throw new Exception("Недопустимые входные данные");
            return Math.Pow(argument, 0.5);
        }
    }
}