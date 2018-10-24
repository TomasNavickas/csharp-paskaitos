using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite studento varda ir pavarde: ");
            var var = Console.ReadLine();
            Console.Write("Iveskite studento grupe : ");
            var grup = Console.ReadLine();
            Console.Write("Iveskite studento aukstaja mokykla: ");
            var mok = Console.ReadLine();
            Console.WriteLine("Iveskite studento matematikos, fizikos ir biologijos vidurkius: ");
            var mat = Convert.ToDouble(Console.ReadLine());
            var fiz = Convert.ToDouble(Console.ReadLine());
            var bio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Studento {0} bendras pazymiu vidurkis yra: " + ((mat+fiz+bio)/3),var);


        }
    }
}
