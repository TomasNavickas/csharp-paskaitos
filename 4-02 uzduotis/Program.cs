using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_02_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda ir pavarde");
            var vardas = Console.ReadLine();
            var pav = Console.ReadLine();
            Console.WriteLine("Sveiki, " + vardas + " " + pav);
            
        }
    }
}
