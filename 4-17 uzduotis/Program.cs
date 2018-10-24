using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite automobilio marke: ");
            var mak1 = Console.ReadLine();
            Console.Write("Iveskite automobilio modeli: ");
            var mod1 = Console.ReadLine();
            Console.Write("Iveskite automobilio darbini turi: ");
            var tur1 = Console.ReadLine();
            Console.Write("Iveskite automobilio gamybos metus: ");
            var met1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite automobilio rida: ");
            var rid1 = Console.ReadLine();
            Console.Write("Ar galioja automobilio TA (true/false): ");
            var ta1 = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Iveskite automobilio marke: ");
            var mak2 = Console.ReadLine();
            Console.Write("Iveskite automobilio modeli: ");
            var mod2 = Console.ReadLine();
            Console.Write("Iveskite automobilio darbini turi: ");
            var tur2 = Console.ReadLine();
            Console.Write("Iveskite automobilio gamybos metus: ");
            var met2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite automobilio rida: ");
            var rid2 = Console.ReadLine();
            Console.Write("Ar galioja automobilio TA: ");
            var ta2 = Convert.ToBoolean(Console.ReadLine());


            Console.WriteLine("+_________+__________+____________+___________+__________+_______+");
            Console.WriteLine("|Marke    |Modelis   |Darb. Turis |Gam. Metai |Rida      |TA     |");
            Console.WriteLine("+_________+__________+____________+___________+__________+______+");
            Console.WriteLine("|{0,6}   |{1,7}   |{2,9}   |{3,8}   |{4,6}    |{5,6} |",mak1,mod1,tur1,met1,rid1,ta1);
            Console.WriteLine("+_________+__________+____________+___________+__________+_______+");
            Console.WriteLine("|{0,6}   |{1,7}   |{2,9}   |{3,8}   |{4,6}    |{5,6} |", mak2,mod2,tur2,met2,rid2,ta2);
            Console.WriteLine("+_________+__________+____________+___________+__________+_______+");

        }
    }
}
