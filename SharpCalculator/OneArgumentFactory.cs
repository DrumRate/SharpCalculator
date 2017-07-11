using System;

namespace SharpCalculator
{
    public static class OneArgumentFactory
    {
        public static IOneAgrumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "sin":
                    return new SineCalculator();
                case "cos":
                    return new CosineCalculator();
                case "tg":
                    return new TanCalculator();
                case "ctg":
                    return new CtanCalculator();
                case "arcsin":
                    return new ArcSineCalculator();
                case "arccos":
                    return new ArcCosineCalculator();
                case "arctg":
                    return new ArctanCalculator();
                case "rev":
                    return new ReversiveCalculator();
                case "abs":
                    return new AbsCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}