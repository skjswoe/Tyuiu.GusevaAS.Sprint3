using Tyuiu.GusevaAS.Sprint3.Task3.V12.Lib;

namespace Tyuiu.GusevaAS.Sprint3.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "bkkkr ckikkcs ksr";
            char item = 'k';

            int res = ds.GetMaxCharCount(str, item);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
