namespace Calculator.view;

public class MainView
{
    public void ShowMenu()
    {
        Console.WriteLine(
            "Главное меню:\n" +
            "1. Калькулятор комплексных чисел\n" +
            "2. Калькулятор рациональных чисел\n" +
            "0. Выход"
        );
        Console.WriteLine("Введите пункт меню: ");
    }
}
