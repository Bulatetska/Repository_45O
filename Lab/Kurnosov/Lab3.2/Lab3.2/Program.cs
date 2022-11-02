using System;
using System.Text;

class Program
{
    public static string CreateFio(string surname, string name, string otchestvo)
    {
        string fio = surname + " " + name + " " + otchestvo + " ";
        return fio;
    }
    public static string CreateFioShort(string surname, string name, string otchestvo)
    {
        string fio = surname + " " + name.Substring(0, 1) + ". " + otchestvo.Substring(0, 1) + ".";
        return fio;
    }
    static void Main()
    {
        string surname = "Лавкрафт";
        string name = "Говард";
        string otchestvo = "Філіпс";
        Console.WriteLine(CreateFio(surname, name, otchestvo));
        Console.WriteLine(CreateFioShort(surname, name, otchestvo));
        Console.ReadLine();
    }
}
