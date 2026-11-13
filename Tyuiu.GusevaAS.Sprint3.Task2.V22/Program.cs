using Tyuiu.GusevaAS.Sprint3.Task2.V22.Lib;

namespace Tyuiu.GusevaAS.Sprint3.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Гусева А. С. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Гусева Алиса Степановна | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
            Console.WriteLine("* произведение ряда по формуле, при х = 5                                 *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"i от {startValue} до {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine("P = " + result);
            Console.ReadLine();
        }
    }
}
