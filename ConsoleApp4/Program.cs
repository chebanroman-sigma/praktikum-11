using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        /// <summary>
        /// Задача 1. Поменять местами содержимое двух строковых переменных.
        /// </summary>
        /// <param name="args"></param>
        public static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string a = Input("a= ");
            string b = Input("b= ");
            Swap(ref a, ref b);
            Console.WriteLine($"результат: {a}\t{b}");
            Console.ReadKey();
        }

        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
}