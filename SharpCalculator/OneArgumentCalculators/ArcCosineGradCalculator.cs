namespace SharpCalculator.OneArgumentCalculators
{
    public class ArcCosineGradCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            var converter = new GradToRadConverter();
            var calculator = new CosineCalculator();
            return calculator.Calculate(converter.Calculate(argument));
        }
    }
}