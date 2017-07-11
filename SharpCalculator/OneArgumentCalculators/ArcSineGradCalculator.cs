namespace SharpCalculator.OneArgumentCalculators
{
    public class ArcSineGradCalculator : IOneAgrumentsCalculator

    {
        public double Calculate(double argument)
        {
            var converter = new GradToRadConverter();
            var calculator = new ArcSineCalculator();
            return calculator.Calculate(converter.Calculate(argument));
        }
    }
}