using Tyuiu.GusevaAS.Sprint3.Task1.V22.Lib;

namespace Tyuiu.GusevaAS.Sprint3.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Гусева А. С. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Гусева Алиса Степановна | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле, при a = 1,5                                                 *");
            Console.WriteLine("***************************************************************************");

            double value = 1.5;
            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine($"a = {value}");
            Console.WriteLine($"k от {startValue} до {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine("S = " + result);

            Console.ReadLine();
        }
    }
}
