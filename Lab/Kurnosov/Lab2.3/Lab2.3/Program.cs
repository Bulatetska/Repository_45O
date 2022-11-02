using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Знаходження площі трикутника");
        Console.Write("a = ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        var b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        var c = double.Parse(Console.ReadLine());

        double S;
        var p = (a + b + c) / 2;
        if (a + b > c && b + c > a && c + a > b)
        {
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("S = {0}", S);
        }
        else
        {
            Console.WriteLine("Трикутник не існує");
        }

        Console.WriteLine("Для виходу натисніть будь-яку клавішу...");
        Console.ReadKey(true);
    }
}
