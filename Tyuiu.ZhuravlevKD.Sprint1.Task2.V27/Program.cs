using Tyuiu.ZhuravlevKD.Sprint1.Task2.V27.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task2.V27;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Известна длина стороны квадрата. Вычислить периметр квадрата.           *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите длину стороны квадрата: ");
        int a = Convert.ToInt32(Console.ReadLine());

        int result = ds.Calculate(a);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Периметр квадрата = {result}");

        Console.ReadKey();
    }
}