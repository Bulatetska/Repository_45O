using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 1, 9, 3 }, { 9, 5, 6 }, { 7, 8, 9 } };
            int max = matrix.Cast<int>().Max(); ;
            
       
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Змiнений масив");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 3; j++)
                {
                    if (matrix[i, j] == max)
                    {
                        matrix[i, j] = 0;
                    }
                        Console.Write(" " + matrix[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
