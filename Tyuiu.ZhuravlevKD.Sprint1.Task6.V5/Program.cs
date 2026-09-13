using Tyuiu.ZhuravlevKD.Sprint1.Task6.V5.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task6.V5;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Пользователь вводит текст. Напечатать те слова, которые являются        *");
        Console.WriteLine("* симметричными (например: казак, шалаш).                                 *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите текст: ");
        string text = Console.ReadLine() ?? "";

        string result = ds.WorkWithText(text);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (!string.IsNullOrEmpty(result))
        {
            Console.WriteLine($"Симметричные слова: {result}");
        }
        else
        {
            Console.WriteLine("Симметричных слов нет.");
        }

        Console.ReadKey();
    }
}