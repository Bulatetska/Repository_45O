using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

        {
            internal class Program
        {
            public static string CreateFio(string name, string surname, string otchestvo)
            {
                string fio = surname + " " + name + " " + otchestvo;
                return fio;
            }
            public static string CreateFioInitials(string surname, string name, string otchestvo)
            {
                string fio = surname + " " + name.Substring(0, 1) + ". " + otchestvo.Substring(0, 1) + ".";

                return fio;
            }
            static void Main()
            {

                string surname = "Св1язов";
                string name = "Артем";
                string otchestvo = "Анатол1йович";

                Console.WriteLine(CreateFio(surname, name, otchestvo));
                Console.WriteLine(CreateFioInitials(surname, name, otchestvo));
                string surname1 = "Ярослав";
                string name1 = "Видринський";
                string otchestvo1 = "Борисович";

                Console.WriteLine(CreateFio(surname1, name1, otchestvo1));
                Console.WriteLine(CreateFioInitials(surname1, name1, otchestvo1));


                Console.ReadLine();
            }
        }
    }
    

