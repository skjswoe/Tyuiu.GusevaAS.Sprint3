using Tyuiu.GusevaAS.Sprint3.Task2.V22.Lib;

namespace Tyuiu.GusevaAS.Sprint3.Task2.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(x, startValue, stopValue);
            double wait = 0.125;

            Assert.AreEqual(wait, res);
        }
    }
}
