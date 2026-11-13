using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GusevaAS.Sprint3.Task6.V17.Lib
{
    public class DataService : ISprint3Task6V17
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalCount = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        totalCount++;
                    }
                }
            }

            return totalCount;
        }
    }
}
