using Tyuiu.ZhuravlevKD.Sprint1.Task4.V30.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task4.V30;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить результат по формуле:                                         *");
        Console.WriteLine("*                         x + y^3                                          *");
        Console.WriteLine("*                         -------                                          *");
        Console.WriteLine("*                          e^2 - y                                         *");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double result = ds.Calculate(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Результат = {result:F3}");

        Console.ReadKey();
    }
}