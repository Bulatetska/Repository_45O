using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = new int[10];
            Random rand = new Random();

            for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(20);
                Console.WriteLine("Element arr " + x + " = " + myArray[x]);
               
            }
            Array.Sort(myArray);
            int maxValue = myArray[myArray.Length - 1];
            Console.WriteLine("max zn = " + maxValue);
            Console.ReadLine();
        }
        
        }
    }

