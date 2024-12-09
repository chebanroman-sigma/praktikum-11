using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {/// <summary>
     /// Задача 4. Создать метод, который будет вычислять площадь круга и 
     /// длину окружности. Вызывающий программный код должен передавать в 
     /// качестве аргумента методу значение радиуса и печатать значение радиуса, 
     /// площади круга и длины окружности.
     /// </summary>
     /// <param name="args"></param>
       
        public static double Input(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());

        }/// <summary>
        /// ввод переменных
        /// </summary>
        /// <param name="args"></param>
       

        public static (double, double) Ploshad(double radius)
        {
            const double pi = Math.PI;
            double S_kr = pi * radius * radius;
            double dl_okr = 2 * pi * radius;
            return (S_kr, dl_okr);

        }
        static void Main(string[] args)
        {
            double radius = Input("радиус круга: ");
            

            (double S_kr, double dl_okr) = Ploshad(radius);

            Console.WriteLine($"Радиус: {radius}");
            Console.WriteLine($"Площадь круга: {S_kr}");
            Console.WriteLine($"Длина окружности: {dl_okr}");
        }
    }
}
