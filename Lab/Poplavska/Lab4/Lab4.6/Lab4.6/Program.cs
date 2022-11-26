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
            int[] myArray = new int[5];
            Random rand = new Random();

            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(10);
                Console.WriteLine("Значення елементу масива " + x + " = " + myArray[x]);
            }
             int sum = myArray.Cast<int>().Sum();
            Console.WriteLine("Сума = " + sum);
            Console.ReadLine();
        }
    }
}
