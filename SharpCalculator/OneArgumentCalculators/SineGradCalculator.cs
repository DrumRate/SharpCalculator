namespace SharpCalculator.OneArgumentCalculators
{
    public class SineGradCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            var converter = new GradToRadConverter();
            var calculator = new SineCalculator();
            return calculator.Calculate(converter.Calculate(argument));
        }
    }
}