using Calculator.model;

namespace Calculator.service;

public class RationalCalculator: Calculator<Rational>
{
    public RationalCalculator() : base()
    {
    }
    
    protected override Rational Sum()
    {
        int numerator = Num1.Numerator * Num2.Denominator + Num1.Denominator * Num2.Numerator;
        int denominator = Num1.Denominator * Num2.Denominator;

        return new Rational(numerator, denominator);
    }

    protected override Rational Difference()
    {
        int numerator = Num1.Numerator * Num2.Denominator - Num1.Denominator * Num2.Numerator;
        int denominator = Num1.Denominator * Num2.Denominator;

        return new Rational(numerator, denominator);
    }

    protected override Rational Multiply()
    {
        int numerator = Num1.Numerator * Num2.Numerator;
        int denominator = Num1.Denominator * Num2.Denominator;

        return new Rational(numerator, denominator);
    }

    protected override Rational Division()
    {
        int numerator = Num1.Numerator * Num2.Denominator;
        int denominator = Num1.Denominator * Num2.Numerator;

        return new Rational(numerator, denominator);
    }
}
