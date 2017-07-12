namespace SharpCalculator.OneArgumentCalculators
{
    /// <summary>
    /// Function to compute the sine in degrees
    /// </summary>
    public class SineGradCalculator : IOneAgrumentsCalculator
    {
        /// <summary>
        /// Method of calculating the sine in degrees
        /// </summary>
        /// <param name="argument">Parametr that is entered by user</param>
        /// <returns></returns>
        public double Calculate(double argument)
        {
            var converter = new GradToRadConverter();
            var calculator = new SineCalculator();
            return calculator.Calculate(converter.Calculate(argument));
        }
    }
}