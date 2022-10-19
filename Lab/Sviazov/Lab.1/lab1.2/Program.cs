using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            System.Console.WriteLine("a = " + a + ", b =  " + b);
            int result = a + b;
            System.Console.WriteLine("Додавання, a + b = " + result);
            result = a * b;
            System.Console.WriteLine("Множення, a * b = " + result + " a  i b - цілі числа, результат - теж");
            double resultDouble = a / b;
            System.Console.WriteLine("Ділення, a / b = " + resultDouble + " помилка...");
            double aDouble = 5;
            resultDouble = aDouble / b;
            System.Console.WriteLine("Ділення, a / b= " + resultDouble);
            System.Console.ReadLine();
        }
    }
}
