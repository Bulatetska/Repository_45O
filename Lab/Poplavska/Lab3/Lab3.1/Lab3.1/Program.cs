using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 100; n++)
            {
                if (n % 15 == 0)
                {
                    Console.WriteLine("Число кратне 3 i 5");
                    continue;
                }
                if (n % 3 == 0)
                {
                    Console.WriteLine("Число кратне 3");
                    continue;
                }

                if (n % 5 == 0)
                {
                    Console.WriteLine("Число кратне 5");
                    continue;
                }

                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
    }

