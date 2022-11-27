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
            int[] myArray = new int[10];
            Random rand = new Random();

            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(20);
                Console.WriteLine("Елемент массиву " + x + " = " + myArray[x]);
              
            }
            Console.WriteLine();

            int Max = myArray.Max<int>();
            int pos = Array.IndexOf(myArray, Max);
            Array.Sort(myArray);
            int maxValue = myArray[myArray.Length - 1];
            Console.WriteLine("Максимальне значення = " + maxValue);
            Console.WriteLine();
            Console.WriteLine("1ндекс елементу = " + pos + ", " +  "К1льк1сть повторень = " + myArray.Count(n => n == Max));
            
            Console.ReadLine();
        }
    }
}