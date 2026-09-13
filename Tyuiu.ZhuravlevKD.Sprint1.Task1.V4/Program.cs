using Tyuiu.ZhuravlevKD.Sprint1.Task1.V4.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task1.V4;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле (x+y)/x*y и печатает его на экране.      *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double result = ds.Calculate(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(result);

        Console.ReadKey();
    }
}