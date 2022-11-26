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
            int[,] matrix = new int[3, 4] {{2,7,3,2},{7,3,5,9},{7,8,9,2}};
            int sum = matrix.Cast<int>().Sum();
            int avarage = sum / (3 * 4);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Середнє значенння = "+ avarage);
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] < avarage )
                    {
                        matrix[i, j] = -1;
                    }
                    if (matrix[i, j] > avarage)
                    {
                        matrix[i, j] = 1;
                    }
                    Console.Write(" " + matrix[i, j]);
                }
            }
            Console.ReadLine();
        }
        }
    }

