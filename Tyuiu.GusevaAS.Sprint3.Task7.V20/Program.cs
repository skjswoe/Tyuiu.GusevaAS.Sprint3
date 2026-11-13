using Tyuiu.GusevaAS.Sprint3.Task7.V20.Lib;

namespace Tyuiu.GusevaAS.Sprint3.Task7.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Гусева А. С. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Гусева Алиса Степановна | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (sin(x) - 2x) / (3x - 1) + sin(x) - 3x + 2                       *");
            Console.WriteLine("* на заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления    *");
            Console.WriteLine("* на ноль. При делении на ноль вернуть значение 0.                        *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Диапазон: от {startValue} до {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("x\tF(x)");
            for (int i = 0; i < result.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"{x}\t{result[i]}");
            }

            Console.ReadLine();
        }
    }
}
