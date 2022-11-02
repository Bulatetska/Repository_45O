using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double p, S ;
          
            if (a + b > c && a + c > b && b + c > a)
            {
                p = ((a + b + c) / 2);
                S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("S={0}", S);
            }
            else {
                Console.WriteLine("Трикутник не iснуватиме");
            }
            Console.ReadLine();
        }
    }
}
