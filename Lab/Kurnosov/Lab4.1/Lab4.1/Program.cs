using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int x = 0; x < arr.Length; x++)
            {
                arr[x] = rand.Next(20);
                System.Console.WriteLine("№" + x + " " + arr[x]);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Максимальне значення = " + arr.Max());
            System.Console.WriteLine();
            System.Console.WriteLine("Кількість повторень - " + arr.Count(n => n == arr.Max()));
            System.Console.ReadLine();
        }
    }
