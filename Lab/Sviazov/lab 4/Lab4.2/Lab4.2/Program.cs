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
            int[,] matrix = { { 5, 2, 5 }, { 2, 4, 1 }, { 5, 3, 3 } };
            int maxNum = matrix.Cast<int>().Max();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (matrix[i, j] == maxNum)
                    {
                        matrix[i, j] = 0;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]);
                    if (matrix[i, j] == maxNum)
                    {
                        matrix[i, j] = 0;
                    }
                }
                Console.ReadLine();
            }
        }
    }
}