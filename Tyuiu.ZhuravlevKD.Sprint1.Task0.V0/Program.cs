using Tyuiu.ZhuravlevKD.Sprint1.Task0.V0.Lib;

namespace Tyuiu.ZhuravlevKD.Sprint1.Task0.V0
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();

            System.Console.Title = "Спринт #1 | Выполнил: Журавлёв К. Д. | СМАРТб-26-1";
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* Спринт #1                                                               *");
            System.Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            System.Console.WriteLine("* Задание #0                                                              *");
            System.Console.WriteLine("* Вариант #0                                                              *");
            System.Console.WriteLine("* Выполнил: Журавлёв Кирилл Дмитриевич | СМАРТб-26-1                      *");
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* УСЛОВИЕ:                                                                *");
            System.Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)            *");
            System.Console.WriteLine("* и печатает результат на экране.                                         *");
            System.Console.WriteLine("*                                                                         *");
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* 10 / (2 + 3)                                                            *");
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            System.Console.WriteLine("***************************************************************************");
            
            System.Console.WriteLine(ds.Calculate());

            System.Console.ReadLine();

        }
    }
}