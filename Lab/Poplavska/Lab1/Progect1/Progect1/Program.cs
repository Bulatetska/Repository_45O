using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progect1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nam = { 5, 10, 7, 14, 6, 11, 5 };

            int minValue = nam[0];

            for (int i = 1; i < nam.Length; i++)
            {
                if (nam[i] < minValue)
                {
                    minValue = nam[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
