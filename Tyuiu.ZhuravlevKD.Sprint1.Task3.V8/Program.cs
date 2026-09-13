using Tyuiu.ZhuravlevKD.Sprint1.Task3.V8.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task3.V8;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить величину дохода по вкладу.                                    *");
        Console.WriteLine("* Процентная ставка и время хранения задаются во время работы программы.  *");
        Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите величину вклада (руб.): ");
        double deposit = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите срок вклада (дней): ");
        int days = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите процентную ставку (% годовых): ");
        double percent = Convert.ToDouble(Console.ReadLine());

        ds.Calculate();

        double income = deposit * percent / 100 * days / 365;
        double total = deposit + income;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Доход: {income:F3} руб.");
        Console.WriteLine($"Сумма по окончании срока вклада: {total:F3} руб.");

        Console.ReadKey();
    }
}