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
            int[,] matrix = new int[6, 9] {
            {1, 2, 3, 4, 5, 6, 7, 8, 9},
            {5, 8, 2, 2, 6, 4, 2, 2, 4},
            {3, 4, 9, 2, 25, 6, 1, 2, 5},
            {6, 4, 5, 5, 6, 4, 7, 3, 5},
            {7, 5, 8, 5, 5, 1, 2, 4, 3},
            {1, 2, 2, 6, 7, 4, 3, 2, 1}
            };

            int max = matrix.Cast<int>().Max();
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(" " + matrix[i, j]);

                    if (matrix[i, j] == max)
                    {
                        for (int q = 0; q < 9; q++)
                        {
                            sum += matrix[i, q];
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сума рядка = " + sum);
            Console.ReadLine();
        }

    }
}
