using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10] ;
            Random rand = new Random();

            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(20);
                Console.WriteLine("Значення елементу масива " + x + " = " + myArray[x]);
             }
            int Max = myArray.Max<int>();
            Console.WriteLine("Максимальне число = "+ Max);
            Console.ReadLine ();
        }
    }
}
