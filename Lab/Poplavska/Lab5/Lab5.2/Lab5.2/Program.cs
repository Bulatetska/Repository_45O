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
            StreamWriter res = new StreamWriter("Lab2res.txt");
            StreamReader dani = new StreamReader("Lab2.txt");
            res.WriteLine("Таблиця значень");
            res.WriteLine("*******************************");
            //s = dani.ReadLine();
            while ((s = dani.ReadLine()) != null)
            {
                x = Convert.ToDouble(s);
                y = ((Math.Pow(x, 2) - (5 * x) + 4) / (Math.Pow(x, 2) + 1));
                res.WriteLine("Arhument x = {0:f3}, y= {1,9:f1}", x,y );
            }

            res.WriteLine("*******************************");
            res.WriteLine("Poplavska");
            
            res.Close();
            dani.Close();
        }
    }
}
