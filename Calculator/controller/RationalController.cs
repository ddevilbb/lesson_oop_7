using Calculator.model;
using Calculator.service;

namespace Calculator.controller;

public class RationalController: CalculatorController<Rational>
{
    public RationalController()
    {
        Title = "Введите числитель и знаменатель первого числа в формате 7 2: ";
        Calculator = new RationalCalculator();
    }
    
    protected override Rational ProcessInput(string[] input)
    {
        try
        {
            int num = Int32.Parse(input[0]);
            int den = Int32.Parse(input[1]);
            if (den == 0)
            {
                throw new DivideByZeroException("Деление на 0!");
            }

            return new Rational(num, den);
        }
        catch (DivideByZeroException e)
        {
            throw;
        }
        catch (Exception)
        {
            throw new Exception("Неверный формат ввода!");
        }
    }
}
