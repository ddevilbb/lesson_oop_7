using Calculator.model;
using Calculator.service;
using Calculator.view;

namespace Calculator.controller;

public abstract class CalculatorController<T>: IController where T: ICalculatorModel
{
    protected CalculatorView<T> _view = new CalculatorView<T>();

    public String Title { get; set; }
    public Calculator<T> Calculator { get; set; }

    public void Run()
    {
        T num1 = InputVariable();
        T num2 = InputVariable();
        String operation = SelectOperation();
        Calculator.Num1 = num1;
        Calculator.Num2 = num2;
        Calculator.Calculate(operation);
        _view.ShowResult(num1, num2, Calculator.Result, operation);
    }

    protected String SelectOperation()
    {
        List<String> allowedOperaitions = new List<string>() {"+", "-", "*", "/"};
        while (true)
        {
            try
            {
                _view.ShowInput("Введите операцию: ");
                String operation = Console.ReadLine()!;
                if (!allowedOperaitions.Contains(operation)) throw new Exception();

                return operation;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Допустимые значения: {allowedOperaitions}");
            }
        }
    }

    protected T InputVariable()
    {
        while (true)
        {
            try
            {
                _view.ShowInput(Title);
                String[] input = Console.ReadLine()!.Split(" ");

                return ProcessInput(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    protected abstract T ProcessInput(String[] input);
}
