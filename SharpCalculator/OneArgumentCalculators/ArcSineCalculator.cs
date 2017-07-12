using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    ///     A function that calculates the sine of number
    /// </summary>
    public class ArcSineCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        ///     The method calculates the sine of number
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument < -1 || argument > 1)
                throw new Exception("Недопустимые входные данные");
            return Math.Asin(argument);
        }
    }
}