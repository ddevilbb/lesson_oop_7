using Calculator.model;
using Calculator.service;

namespace Calculator.controller;

public class ComplexController: CalculatorController<Complex>
{
    public ComplexController()
    {
        Title = "Введите вещественную и мнимую части первого числа в формате -2.5 5: ";
        Calculator = new ComplexCalculator();
    }
    
    protected override Complex ProcessInput(string[] input)
    {
        try
        {
            double real = Double.Parse(input[0]);
            double image = Double.Parse(input[1]);

            return new Complex(real, image);
        }
        catch (Exception)
        {
            throw new Exception("Неверный формат ввода!");
        }
    }
}
