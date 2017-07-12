using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    ///     A function that computes the arc cosine of number in degrees
    /// </summary>
    public class ArcCosineGradCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        ///     The method calculates the arc cosine of number in degrees
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if (argument < -1 || argument > 1)
                throw new Exception("Недопустимые входные данные");
            var converter = new RadToGradConverter();
            var calculator = new ArcCosineCalculator();
            return converter.Calculate(calculator.Calculate(argument));
        }
    }
}