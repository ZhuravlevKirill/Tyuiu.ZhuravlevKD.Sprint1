using Tyuiu.ZhuravlevKD.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task5.V7;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Определить h – полное количество часов, прошедших от начала суток       *");
        Console.WriteLine("* до того момента (в первой половине дня), когда часовая стрелка           *");
        Console.WriteLine("* повернулась на f градусов (0 < f < 360, f – вещественное число).       *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите угол поворота часовой стрелки в градусах: ");
        double f = Convert.ToDouble(Console.ReadLine());

        int result = ds.AngleToHoursMinutes(f);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Полное количество часов = {result}");

        Console.ReadKey();
    }
}