using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = { { 4, 5, 1 }, { 3, 5, 1 }, { 2, 5, 4 } };
        int arrMax = arr.Cast<int>().Max();
        for (int i = 0; i < 3; i++)
        {
            for (int x = 0; x < 3; x++)
            {
                System.Console.Write(arr[i, x]);
                if (arr[i, x] == arrMax)
                {
                    arr[i, x] = 0;
                }
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("Результат:");

        for (int i = 0; i < 3; i++)
        {
            for (int x = 0; x < 3; x++)
            {
                System.Console.Write(arr[i, x]);

            }
            System.Console.WriteLine();
        }
        System.Console.ReadLine();
    }
}

