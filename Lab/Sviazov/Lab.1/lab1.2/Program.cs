﻿using System;
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
            string stringToShow1, stringToShow2;
            string surname = "Johnson";
            string name = "Joe";
            string secondname = "Yu";

            int age = 40;
            double weight = 88.73;

            stringToShow1 = surname + " " + name + " " + secondname + ", age " + age + ", weight " + weight;
            surname = "Marcus";
            name = "Alex";
            secondname = "Fu";
            stringToShow2 = surname + " " + name + " " + secondname + ", age " + age + ", weight " + weight;
            System.Console.WriteLine(stringToShow1);
            System.Console.WriteLine(stringToShow2);
            System.Console.ReadLine();
        }
    }
}
