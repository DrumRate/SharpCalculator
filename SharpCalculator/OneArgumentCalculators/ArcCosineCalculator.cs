using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    ///     A function that calculates the arccosine of a number
    /// </summary>
    public class ArcCosineCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        ///     A method that calculates the arccosine of a number
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument < -1 || argument > 1)
                throw new Exception("Недопустимые входные данные");
            return Math.Acos(argument);
        }
    }
}