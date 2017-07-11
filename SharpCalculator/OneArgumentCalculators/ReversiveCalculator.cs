namespace SharpCalculator.OneArgumentCalculators
{
    public class ReversiveCalculator : IOneAgrumentsCalculator
    {
        public double Calculate(double argument)
        {
            return 1 / argument;
        }
    }
}