using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jei geriate vandeni pasirinkite 1");
            Console.WriteLine("Jei geriate arbata pasirinkite 2");
            Console.WriteLine("Jei geriate kava pasirinkite 3");
            Console.WriteLine("Jei geriate alu pasirinkite 4");
            var ger = Convert.ToInt32(Console.ReadLine());
            switch (ger)
            {
                case 1:
                    Console.WriteLine("Geriate vandeni. Sveika.");
                    break;
                case 2:
                    Console.WriteLine("Geriate arbata. Silta.");
                    break;
                case 3:
                    Console.WriteLine("Geriate kava. Nemiegosite.");
                    break;
                case 4:
                    Console.WriteLine("Geriate alu");
                    Console.WriteLine("Ar alus alkoholinis?");
                    var alus = Console.ReadLine();
                    if (alus == "taip")
                    {
                        Console.WriteLine("negalite vairuoti");
                    }
                    else
                    {
                        Console.WriteLine("vartok atsakingai");
                    }
                    break;
                default:
                    Console.WriteLine("normaliai paklausiau, is naujo..");
                    break;
            }
        }
    }
}
