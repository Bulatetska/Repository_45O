using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            int[,] Arr = new int[6, 9] { 
            {1,1,1,1,1,1,1,1,1}, 
            {1,1,1,1,2,1,1,1,1}, 
            {1,1,1,1,1,1,1,1,1}, 
            {1,1,1,1,1,1,1,1,1}, 
            {1,1,1,1,1,1,1,1,1}, 
            {1,1,1,1,1,1,1,1,1}, 
            };
            int ArrMax = Arr.Cast<int>().Max();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(" " + Arr[i, j]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Arr[i, j] == ArrMax)
                    {
                        for (int x = 0; x < 9; x++)
                        {
                            Sum += Arr[i, x];
                        }
                    }

                }
            }
            Console.Write("Сума строки = " + Sum);
            Console.ReadLine();
        }
    }
}