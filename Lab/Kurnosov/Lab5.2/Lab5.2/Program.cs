using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double x, y;
            StreamWriter a = new StreamWriter("Lab2res.txt");
            StreamReader b = new StreamReader("Lab2.txt");
            a.WriteLine("Таблиця значень");
            a.WriteLine("+---------------------------------+");
            a.WriteLine("+   Аргумет      +     Значення   +");
            a.WriteLine("+---------------------------------+");
            //s = dani.ReadLine();
            while ((s = b.ReadLine()) != null)
            {
                x = Convert.ToDouble(s);
                y = (Math.Log(Math.PI))*(Math.Sqrt(Math.Pow(x, 3) + Math.Pow(x, 2)));
                a.WriteLine("+  x = {0:f1}    +   y= {1,9:f2}   +", x, y);
            }

            a.WriteLine("+---------------------------------+");
            a.WriteLine("Склав<Курносов В.О.>");

            a.Close();
            a.Close();
            System.Console.ReadLine();
        }
    }
}