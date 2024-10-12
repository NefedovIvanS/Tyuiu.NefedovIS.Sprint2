using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NefedovIS.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((((x >= 3) && (x <= 5) || (x >= 9) && (x <= 12)) && ((y == 3) || (y == 4))) ||
                (((x >= 3) && (x <= 12)) && (y == 5)) ||
                (((x >= 3) && (x <= 13)) && ((y == 5) || (y == 6))) ||
                (((x == 4) || (x >= 6) && (x <= 13)) && (y == 8)) ||
                (((x == 4) || (x >= 6) && (x <= 9)) && (y == 9)) ||
                (((x == 4) || (x == 8) || (x == 9)) && ((y == 10) || (y == 12))) ||
                (((x >= 3) && (x <= 5) || (x == 8) || (x == 9)) && (y == 11)) ||
                ((x == 4) && (y == 13)) ||
                ((x >= 2) && (x <= 6) && (y == 14))
                )
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
