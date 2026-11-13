using Tyuiu.GusevaAS.Sprint3.Task7.V20.Lib;

namespace Tyuiu.GusevaAS.Sprint3.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            Assert.AreEqual(11, res.Length);

            double[] wait = { 17.27, 14.08 };
            Assert.AreEqual(wait[0], res[0]);
            Assert.AreEqual(wait[1], res[1]);
        }
    }
}
