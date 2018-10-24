using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_03_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koks tai gyvunas?");
            var gyvunas = Console.ReadLine();
            Console.WriteLine("Kokia jo seima?");
            var seima = Console.ReadLine();
            Console.WriteLine("Kur ji galima sutikti?");
            var kur = Console.ReadLine();
            Console.WriteLine("Tai " + gyvunas + " jis yra " + seima + " seimos atstovas, ji galima sutikti " + kur);


        }
    }
}
