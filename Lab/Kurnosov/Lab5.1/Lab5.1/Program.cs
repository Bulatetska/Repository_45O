using System;
class HelloWorld
{
    static void Main()
    {
        double A;
        int I;
        float C;
        bool L;
        string N;
        Console.WriteLine("Введіть A");
        A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть I");
        I = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введіть C");
        C = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Введіть L");
        L = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Введіть N");
        N = Console.ReadLine();
        System.Console.WriteLine(" Результат: ");
        System.Console.WriteLine("A = {0,100:f3}", A);
        System.Console.WriteLine("I ={0, 7}", I);
        System.Console.WriteLine("C = {0,10:f2}", C);
        System.Console.WriteLine("L = {0, 5}", L);
        System.Console.WriteLine("Імʼя = {0, 9}", N);
        System.Console.WriteLine(" ");
        System.Console.ReadLine();
    }
}