using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {/// <summary>
     /// Задача 3. Ввести три целых числа и вывести их в порядке возрастания значений.
     /// </summary>
     /// <param name="args"></param>

        public static int Input(string message)
        { 
        Console.Write(message);
            return int.Parse(Console.ReadLine());
        }/// <summary>
        /// ввод переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static void Vozrast(int a, int b, int c)
        {

            if (a < b && a < c)
            {
                Console.WriteLine($"Результат: {a}\t{Math.Min(b,c)}\t{Math.Max(b,c)}");
            }
            if (b < a && b < c)
            {
                Console.WriteLine($"Результат: {b}\t{Math.Min(a, c)}\t{Math.Max(a, c)}");
            }
            if (c < b && c < a)
            {
                Console.WriteLine($"Результат: {c}\t{Math.Min(b, a)}\t{Math.Max(b, a)}");
            }

        }/// <summary>
        /// сопостовление чисел в порядке возрастания
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("b= ");
            int c = Input("c= ");
            Vozrast(a,b,c);
            Console.ReadKey();
        }
    }
}
