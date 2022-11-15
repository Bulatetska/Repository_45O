using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 4, 5, 1 }, { 4, 5, 1 }, { 4, 5, 1 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    System.Console.Write(arr[i, j]);
                    if (arr[i, j] == arr.Max())
                    {
                        arr[i, j] = 0;
                    }
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("---");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    System.Console.Write(arr[i, j]);

                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("==========");
        }
    }
}
