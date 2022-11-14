using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int x = 0; x < arr.Length; x++)
            {
                arr[x] = rand.Next(10);
                Console.WriteLine(arr[x]);
            }
            Console.WriteLine();
            Console.WriteLine("Сума елементів=" + arr.Sum());
            Console.ReadLine();
        }
    }
}
