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
            int[,] matrixRectangle = { { 1, 4, 3, 2 }, { 6, 3, 2, 2 }, { 4, 2, 3, 5 } };
            int RectangleSum = matrixRectangle.Cast<int>().Sum();
            int center = RectangleSum / (3 * 4);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrixRectangle[i, j]);

                    if (matrixRectangle[i, j] < center)
                    {
                        matrixRectangle[i, j] = -1;
                    }
                    if (matrixRectangle[i, j] > center) 
                    {
                        matrixRectangle[i, j] = 1;
                    }

                }
                Console.WriteLine();

            }
            Console.WriteLine();
            Console.WriteLine("Середнє значенння = " + center);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.Write(" " + matrixRectangle[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}