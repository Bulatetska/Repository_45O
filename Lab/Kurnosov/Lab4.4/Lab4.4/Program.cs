using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Lab4
    {
        static void Main(string[] args)
        {
            int[,] Arr = new int [3,4] {{1,2,3,4},{4,3,2,1},{3,4,1,2}};
            int Sum = Arr.Cast<int>().Sum();
            int mid = Sum / (3 * 4);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    System.Console.Write(Arr[i, j]);
                    if (Arr[i, j] < mid)
                    {
                        Arr[i, j] = -1;
                    }
                    if (Arr[i, j] > mid)
                    {
                        Arr[i, j] = 1;
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("Результат:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    System.Console.Write(Arr[i, j]);
                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
        }
}

