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
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("krante 3 i 5");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("kratne 3");
                    continue;
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine("kratne 5");
                    continue;
                }


                Console.WriteLine(i);

            }
            Console.ReadLine();
        }
    }
}