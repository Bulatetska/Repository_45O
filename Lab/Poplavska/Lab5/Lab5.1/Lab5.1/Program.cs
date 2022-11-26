using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    //10
    class Program
    {
        static void Main(string[] args)
        {
            int I;
            float A;
            double C;
            bool L;
            string N_prizvushe;
            Console.WriteLine("Введiть призвiще : ");
            N_prizvushe = Console.ReadLine();
            Console.WriteLine("Введiть I : ");
            I = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть A : ");
            A = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введiть C : ");
            C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть L : ");
            L = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Призвiще : N_prizvushe = {0,10}, L = {1,4} ", N_prizvushe,L);
            Console.WriteLine("I = {0,4}, A = {1,10:f2}, C = {1,20:e8} ", I, A, C);
            Console.ReadLine();

        }
    }
}
