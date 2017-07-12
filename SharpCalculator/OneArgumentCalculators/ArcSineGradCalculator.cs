using System;

namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function calculates the arc sine of an angle in degrees
    /// </summary>
    public class ArcSineGradCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// The method calculates the arc sine of an angle in degrees
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            if ((argument < -1) & (argument > 1))
                throw new Exception("Недопустимые входные данные");
            var converter = new RadToGradConverter();
            var calculator = new ArcSineCalculator();
            return converter.Calculate(calculator.Calculate(argument));
        }
    }
}