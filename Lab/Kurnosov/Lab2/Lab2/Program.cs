using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolVariable = true;
            if (boolVariable)
            {
                System.Console.WriteLine("boolVariable = true; --- Істина!");
            }
            else
            {
                System.Console.WriteLine("boolVariable = falce; --- Хибно!");
            }
            System.Console.WriteLine();

            boolVariable = false;
            if (boolVariable)
            {
                System.Console.WriteLine("boolVariable = falce; --- Істина!");
            }
            else
            {
                System.Console.WriteLine("boolVariable = falce; --- Хибно!");
            }

            boolVariable = 2 < 4;
            if (boolVariable)
            {
                System.Console.WriteLine("boolVariable = 2 < 4; --- Істина!");
            }
            else
            {
                System.Console.WriteLine("boolVariable = 2 < 4; --- Хибно!");
            }

            if (10 != 100)
            {
                System.Console.WriteLine("10 != 100! --- Різні числа!");
            }
            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }
}
