using Tyuiu.NefedovIS.Sprint2.Task1.V6.Lib;

namespace Tyuiu.NefedovIS.Sprint2.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int a = 915;
            int b = 169;
            int c = 174;
            int d = 133;
            bool[] res = new bool[6];
            bool[] wait = new bool[6] { false, false, true, false, true, false};
            res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);

        }
    }
}