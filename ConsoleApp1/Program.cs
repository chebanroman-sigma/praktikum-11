using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {/// <summary>
     /// Задача 5. Даны стороны двух треугольников. Найти сумму их периметров
     /// и сумму их площадей. (Определить вспомогательный метод для расчета периметра 
     /// и площади треугольника по его сторонам.)
     /// </summary>
     /// <param name="args"></param>

        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }/// <summary>
        /// ввод переменных
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>

        public static double Perimetr(double x, double y, double z)
        {
            return (x + y + z);
        }/// <summary>
        /// периметр
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public static double Ploshad(double x, double y, double z)
        {
            double s = (x + y + z) / 2;
            return Math.Sqrt(s * (s - x) * (s - y) * (s - z));
        }/// <summary>
        /// площадь
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            int c = Input("c= ");

            int a1 = Input("a1= ");
            int b1 = Input("b1= ");
            int c1 = Input("c1= ");
            double P1 = Perimetr(a, b, c);
            double P2 = Perimetr(a1, b1, c1);
            double S1 = Ploshad(a, b, c1);
            double S2 = Ploshad(a1, b1, c1);

            Console.WriteLine($"сумма периметров:{P1+P2}");
            Console.WriteLine($"сумма площадей:{S1+S2}");
        }
    }
}
