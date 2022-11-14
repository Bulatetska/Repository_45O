using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            Random rand = new Random();

            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(10);
                Console.WriteLine( myArray[x]);
                
            }
            Console.WriteLine("Сума елемент1в массиву = " + myArray.Sum());
            Console.ReadLine();
        }
    }
}
