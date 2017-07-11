using System;
using System.Runtime.Remoting.Messaging;
using SharpCalculator.OneArgumentCalculators;

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
                case "ln":
                    return new LnCalculator();
                case "log":
                    return new LogTwoCalculator();
                case "lg":
                    return new LgCalculator();
                case "invert":
                    return new InvertCalculator();
                case "exp":
                    return new ExpCalculator();
                case "exp2":
                    return new ExponentialFunctionTwoCalculator();
                case "exp10":
                    return new ExponentialFunctionTenCalculator();
                case "sqr":
                    return new SquareRootCalculator();
                case "gradToRad":
                    return new RadToGradConverter();
                case "radToGrad":
                    return new GradToRadConverter();
                case "arcsinGrad":
                    return new ArcSineGradCalculator();
                case "sinGrad":
                    return new SineGradCalculator();
                case "cosGrad":
                    return new CosineGradCalculator();
                case "arccosGrad":
                    return new ArcCosineGradCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}