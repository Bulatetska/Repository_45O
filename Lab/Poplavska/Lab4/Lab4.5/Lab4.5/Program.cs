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
           { 1, 9, 3, 3, 4, 2, 6, 7, 8 }, 
           { 1, 9, 3, 3, 4, 2, 6, 7, 8 }, 
           { 1, 9, 3, 3, 4, 2, 6, 7, 8 }, 
           { 1, 9, 3, 3, 44, 2, 6, 7, 8 }, 
           { 1, 9, 3, 3, 4, 2, 6, 7, 8 }, 
           { 1, 9, 3, 3, 4, 2, 6, 7, 8 }, 
           };
            int max = matrix.Cast<int>().Max(); 
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (matrix[i,j] == max)
                    {
                        for (int x = 0; x < 9; x++ )
                        {
                            sum += matrix[i, x];
                        }
                    }
                    
                }
            }
            Console.Write("Сума рядка з найбiльшим елементом = " + sum);
            Console.ReadLine();
        }
        }
    }

