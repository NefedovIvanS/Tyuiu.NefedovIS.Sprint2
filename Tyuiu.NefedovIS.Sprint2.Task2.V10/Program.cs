using Tyuiu.NefedovIS.Sprint2.Task2.V10.Lib;

namespace Tyuiu.NefedovIS.Sprint2.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
