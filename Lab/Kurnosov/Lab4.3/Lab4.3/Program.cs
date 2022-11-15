using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 3, 2, 2, 0, 0, 1, 1 };
        int plusCouple = 0;
        int zeroCouple = 0;
        for (int i = 0; i < arr.Length; i++)
        {

            System.Console.Write(arr[i] + " ");
            if (i + 1 < arr.Length)
            {
                if (arr[i] > 0 && arr[i + 1] > 1)
                {
                    plusCouple++;
                }

                if (arr[i] == 0 && arr[i + 1] > 0)
                {
                    zeroCouple++;
                }
            }

        }
        System.Console.WriteLine();
        System.Console.WriteLine("Plus couples : " + plusCouple);
        System.Console.WriteLine("Zero couples: " + zeroCouple);
        System.Console.ReadLine();
    }
}

