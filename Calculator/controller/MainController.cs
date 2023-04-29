using Calculator.view;

namespace Calculator.controller;

public class MainController: IController
{
    public void Run()
    {
        MainView mainView = new MainView();
        while (true)
        {
            mainView.ShowMenu();
            int menuIndex = Convert.ToInt32(Console.ReadLine());
            IController? controller = null;
            switch (menuIndex)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    controller = new ComplexController();
                    break;
                case 2:
                    controller = new RationalController();
                    break;
                default:
                    Console.WriteLine("Данного пункта нет в меню!");
                    continue;
            }
            controller.Run();
        }
    }
}
