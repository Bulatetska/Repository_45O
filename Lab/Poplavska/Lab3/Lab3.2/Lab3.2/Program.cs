using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    internal class Program
    {
        public static string CreateFio(string name, string surname, string pobatkovi)
        {
            string fio = surname + " " + name + " " + pobatkovi;
            return fio;
        }
        public static string CreateFioInitials(string surname, string name, string pobatkovi)
        {
            string fio = surname + " " + name.Substring(0, 1) + ". " + pobatkovi.Substring(0, 1) + ".";

            return fio;
        }
        static void Main()
        {

            string surname = "Шевченко";
            string name = "Тарас";
            string pobatkovi = "Григорович";

            System.Console.WriteLine(CreateFio(surname, name, pobatkovi));
            System.Console.WriteLine(CreateFioInitials(surname, name, pobatkovi));
            Console.ReadLine();
        }
    }
  }

