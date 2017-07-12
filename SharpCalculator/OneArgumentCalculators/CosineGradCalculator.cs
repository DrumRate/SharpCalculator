namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    ///     The function calculates the cosine of number in degrees
    /// </summary>
    public class CosineGradCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        ///     The method calculates the cosine of number in degrees
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            var converter = new GradToRadConverter();
            var calculator = new CosineCalculator();
            return calculator.Calculate(converter.Calculate(argument));
        }
    }
}