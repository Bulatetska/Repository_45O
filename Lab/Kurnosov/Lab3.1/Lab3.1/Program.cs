using System;
using System.Text;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 101; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine("Кратне трьом і п'яти");
                continue;
            }
            if (i % 3 == 0)
            {
                Console.WriteLine("Кратне трьом");
                continue;
            }
            if (i % 5 == 0)
            {
                Console.WriteLine("Кратне п'яти");
                continue;
            }
            Console.WriteLine("i={0}", i);
        }
        Console.ReadLine();
    }
}
