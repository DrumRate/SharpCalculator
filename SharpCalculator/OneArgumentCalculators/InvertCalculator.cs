namespace SharpCalculator.OneArgumentCalculators
{
    public class InvertCalculator : IOneAgrumentsCalculator

    {
        public double Calculate(double argument)
        {
            return -argument;
        }
    }
}