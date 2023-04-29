using Calculator.model;

namespace Calculator.service;

public class ComplexCalculator: Calculator<Complex>
{
    public ComplexCalculator(): base()
    {
    }
    
    protected override Complex Sum()
    {
        double real = Num1.Real + Num2.Real;
        double image = Num1.Image + Num2.Image;

        return new Complex(real, image);
    }

    protected override Complex Difference()
    {
        double real = Num1.Real - Num2.Real;
        double image = Num1.Image - Num2.Image;

        return new Complex(real, image);
    }

    protected override Complex Multiply()
    {
        double real = Num1.Real * Num2.Real - Num1.Image * Num2.Image;
        double image = Num1.Real * Num2.Image + Num1.Image * Num2.Real;

        return new Complex(real, image);
    }

    protected override Complex Division()
    {
        double scale = 10;
        double denominator = Math.Pow(Num2.Real, 2) + Math.Pow(Num2.Image, 2);
        double real = Math.Ceiling(((Num1.Real * Num2.Real + Num1.Image * Num2.Image) / denominator) * scale) / scale;
        double image = Math.Ceiling(((Num1.Image * Num2.Real - Num1.Real * Num2.Image) / denominator) * scale) / scale;

        return new Complex(real, image);
    }
}
