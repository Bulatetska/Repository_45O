﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            System.Console.WriteLine("a= " + a + ", b=" + b);
            int result = a + b;
            System.Console.WriteLine("Додавання a+b=" + result);
            result = a * b;
            System.Console.WriteLine("Множення a*b=" + result);
            result = a / b;
            System.Console.WriteLine("Ділення a/b=" + result + "a та b - цілі числа, результат - теж");
            double resultDouble = a / b;
            System.Console.WriteLine("Ділення a/b=" + resultDouble + "помилка...");
            double aDouble = 5;
            resultDouble = aDouble / b;
            System.Console.WriteLine("Ділення a/b=" + resultDouble);
            System.Console.ReadLine();
        }
    }
}
