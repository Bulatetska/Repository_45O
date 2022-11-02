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

            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Дискримiнант = "+ discriminant);
            double x1, x2;
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратне рiвняння не має коренiв");
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
