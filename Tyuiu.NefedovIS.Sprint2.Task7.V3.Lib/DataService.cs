using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NefedovIS.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x*x + Math.Pow(y - 1, 2) < 1) && (1 - x * x > y))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
