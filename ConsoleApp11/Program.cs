
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {/// <summary>
     /// Задача 2. Даны 8 различных чисел. Определить максимальное 
     /// из них, используя функцию определения максимального из двух чисел.
     /// </summary>

        static void Value()
        {
            int number1 = Input("q=");
            int number2 = Input("w=");
            int number3 = Input("e=");
            int number4 = Input("r=");
            int number5 = Input("t=");
            int number6 = Input("y=");
            int number7 = Input("u=");
            int number8 = Input("i=");
            int max = Func(Func(Func(number5, number6), Func(number7, number8)),
                      Func(Func(number1, number2), Func(number3, number4)));
            Console.WriteLine($"Наибольшее число = {max} ");


            Console.ReadLine();
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static int Func(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
       
        static void Main(string[] args)
        {
            Value();
        }
    }
}