using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GusevaAS.Sprint3.Task2.V22.Lib
{
    public class DataService : ISprint3Task2V22
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            int i = startValue;

            do
            {
                double term = 3.0 / (i + value);
                p *= Math.Pow(term, 2);
                i++;
            } while (i <= stopValue);

            return Math.Round(p, 3);
        }
    }
}
