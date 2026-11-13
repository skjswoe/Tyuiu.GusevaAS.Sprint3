using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GusevaAS.Sprint3.Task4.V23.Lib
{
    public class DataService : ISprint3Task4V23
    {
        public double Calculate(int startValue, int stopValue)
        {
            double p = 1;

            for (int x = startValue; x <= stopValue; x++)
            {

                if (x == 0)
                {
                    break;
                }

                double y = (Math.Cos(x) / x) + 3;
                p *= y;
            }

            return Math.Round(p, 3);
        }
    }
}
