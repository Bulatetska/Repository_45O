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
            Console.WriteLine("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = (b * b) - (4 * a * c);

            double x1, x2;
            if (discriminant < 0)
            {
                Console.WriteLine("None root");
            }
            else
            {

                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1={0}, x2={1}", x1, x2);
            }


            Console.ReadLine();
        }
    }
}