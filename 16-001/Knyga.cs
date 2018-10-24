using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_001
{
    class Knyga
    {
        public string Pavadinimas { get; private set; }
        public string Autorius { get; private set; }
        public int Puslapiai { get; private set; }
        public string Zanras { get; private set; }
        public double Kaina { get; private set; }
        public int Kiekis { get; private set; }
        public double Savikaina { get; private set; } // propg TAB + TAB

        public Knyga(string pavadinimas, string autorius, int puslapiai, string zanras, double kaina, int kiekis, double savikaina)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Puslapiai = puslapiai;
            Zanras = zanras;
            Kaina = kaina;
            Kiekis = kiekis;
            Savikaina = savikaina;
        }
        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Knygos autorius " + Autorius);
            Console.WriteLine("Knygoje yra {0} puslapiu ", Puslapiai);
            Console.WriteLine("Knygos zanras: " + Zanras);
            Console.WriteLine("Si knyga kainuoja " + Kaina);
            Console.WriteLine("Sandelyje yra: " + Kiekis);
            Console.WriteLine("Pardavus viska turesime {0}e/men apyvartos ir {1} pelna.", Apyvarta(), Pelnas());
            Console.WriteLine("--");
        }
        public double Apyvarta()
        {
            return Kiekis * Kaina;
        }
        public double Pelnas()
        {
            return (Kaina - Savikaina) * Kiekis;
        }
    }
}
