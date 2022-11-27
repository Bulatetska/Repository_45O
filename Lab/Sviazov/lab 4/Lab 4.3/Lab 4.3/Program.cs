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
            int[] num = { -1, 3, 2, -4, -1, 5, 3, 0, 0, 1, -2, -1, 3, 0, 0 };
            int zeroCount = 0;
            int plusCount = 0;
            for (int i = 0; i < num.Length; i++)
            {

                Console.Write(num[i] + " ");
                if (i + 1 < num.Length)
                {
                    if (num[i] > 0 && num[i + 1] > 0)
                    {
                        plusCount++;
                    }

                    if (num[i] == 0 && num[i + 1] == 0)
                    {
                        zeroCount++;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("К1льк1сть нульових сус1дств: " + zeroCount);
            Console.WriteLine("К1льк1сть додатн1х сус1дств: " + plusCount);
            Console.ReadLine();
        }
    }
}