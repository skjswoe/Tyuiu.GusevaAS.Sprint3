using Tyuiu.GusevaAS.Sprint3.Task3.V12.Lib;

namespace Tyuiu.GusevaAS.Sprint3.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Гусева А. С. | РППб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Гусева Алиса Степановна | РППб-26-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв k,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: bkkrk ckkkcs ksr             *");
            Console.WriteLine("***************************************************************************");

            string str = "bkkkr ckikkcs ksr";
            char item = 'k';

            Console.WriteLine("Строка: " + str);
            Console.WriteLine("Искомый символ: " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetMaxCharCount(str, item);

            Console.WriteLine("Максимальное количество подряд: " + result);
            Console.ReadLine();
        }
    }
}
