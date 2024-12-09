using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {/// <summary>
     /// Задача 2. Составить программу, в результате которой величина 
     /// а меняется значением с величиной b, а величина c — с величиной d.
     /// </summary>
     /// <param name="message"></param>
     /// <returns></returns>
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = Input("a= ");
            int b = Input("a= ");
            int c = Input("a= ");
            int d = Input("a= ");
            Console.WriteLine($"Результат до:\t\t{a}\t{b}\t{c}\t{d}");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.Write($"Результат после:\t{a}\t{b}\t{c}\t{d}");
            Console.ReadKey();
        }
    }
}
