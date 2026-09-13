using Tyuiu.ZhuravlevKD.Sprint1.Task7.V1.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task7.V1;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить математическое выражение:                                     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*              b + √(b² + 4ac)                                           *");
        Console.WriteLine("* z = ─────────────────────── - a³c + b⁻²                                *");
        Console.WriteLine("*                    2a                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double result = ds.Calculate(a, b, c, 0);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"z = {result:F3}");

        Console.ReadKey();
    }
}