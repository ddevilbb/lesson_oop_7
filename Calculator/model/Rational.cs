namespace Calculator.model;

public class Rational: ICalculatorModel
{
    public Rational(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
    }

    public int Numerator { get; set; }
   
    public int Denominator { get; set; }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
