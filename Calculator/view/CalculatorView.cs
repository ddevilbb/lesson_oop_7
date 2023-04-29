using Calculator.model;

namespace Calculator.view;

public class CalculatorView<T> where T: ICalculatorModel
{
    public void ShowInput(String title)
    {
        System.Console.WriteLine(title);
    }

    public void ShowResult(T num1, T num2, T result, String operation)
    {
        System.Console.WriteLine($"{num1} {operation} {num2} = {result}");
    }
}
