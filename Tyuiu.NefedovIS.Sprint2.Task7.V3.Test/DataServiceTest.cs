using Tyuiu.NefedovIS.Sprint2.Task7.V3.Lib;

namespace Tyuiu.NefedovIS.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0.5;
            bool wait = true;
            Assert.AreEqual(wait, ds.CheckDotInShadedArea(x, y));
        }
    }
}