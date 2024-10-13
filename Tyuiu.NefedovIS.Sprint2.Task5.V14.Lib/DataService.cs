﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NefedovIS.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string[] days = { "","Понедельник", "Вторник", "Среда", "Четверг",
                "Пятница", "Суббота", "Воскресенье" };
            string res = "";
            switch (k % 7)
            {
                case 1:
                    res = days[d];
                    break;
                case 2:
                    res = days[d];
                    break;
                case 3:
                    res = days[d];
                    break;
                case 4:
                    res = days[d];
                    break;
                case 5:
                    res = days[d];
                    break;
                case 6:
                    res = days[d];
                    break;
                case 0:
                    res = days[d];
                    break;
            }
            return res;
        }
    }
}
