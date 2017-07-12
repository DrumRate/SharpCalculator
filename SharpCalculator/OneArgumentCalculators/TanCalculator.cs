using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function to compute the tangent of number
    /// </summary>
    public class TanCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method to compute the tangent of number
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if ((argument.Equals(Math.PI / 2)) || (argument.Equals(3 * Math.PI / 2)))
                throw new Exception("Недопустимое значение");
            return Math.Tan(argument);
        }
    }
}