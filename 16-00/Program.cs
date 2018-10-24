using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_00
{
    class Lektuvas // sukruta nauja klase
    {
        public int SparnuIlgis;
        public string Pavadinimas;
        public int Vietos;
        public string Klase;
        public int VarikliuSkaicius;
        public string VariklioTipas;

        public Lektuvas() { } // jei yra tuscias kvietimas - " var lektuvas1 = new Lektuvas(); ", tai reikia padaryti viena tuscia konsturktoriu

        public Lektuvas(int Sparnuilgis, string pavadinimas, int vietos, string klase, int varikliuskaicius, string varikliotipas)
        {
            this.SparnuIlgis = Sparnuilgis; // this rodo i klase
            Pavadinimas = pavadinimas;
            Vietos = vietos;
            Klase = klase;
            VarikliuSkaicius = varikliuskaicius;
            VariklioTipas = varikliotipas;
        }

        public void Isvedimas() // metodas kuris nieko nedaro kol nera kvieciamas
        {
            Console.WriteLine("Lektuvas {0} turi {1} vietu, jo sparnai yra {2}m. ilgio, jo variklis {3}", Pavadinimas, Vietos, SparnuIlgis, VariklioTipas);
            Console.WriteLine("Jis yra {0} yra klases, nes turi net {1} variklius", Klase, VarikliuSkaicius);
            Console.WriteLine();
            Console.WriteLine("sparno ilgis: {0}", VienasSparnas());
            Console.WriteLine("Lekktuve keleiviu: {0}", KiekKeleiviu());
        }
        public int VienasSparnas()
        {
            var sparnas = SparnuIlgis / 2;

            return sparnas;
        }
        public int KiekKeleiviu()
        {
            Random rand = new Random();
            return rand.Next(Vietos);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var lektuvas1 = new Lektuvas();
            var lektuvas2 = new Lektuvas(); // susikuriam objektus


            lektuvas1.Pavadinimas = "Boeying"; // supildom lektuu duomenis
            lektuvas1.Vietos = 80;
            lektuvas1.Klase = "Tarpatlantinis";
            lektuvas1.SparnuIlgis = 50;
            lektuvas1.VariklioTipas = "Turbo";
            lektuvas1.VarikliuSkaicius = 2;

            lektuvas2.Pavadinimas = "Kukuruznikas";
            lektuvas2.Vietos = 2;
            lektuvas2.Klase = "Ukinis";
            lektuvas2.SparnuIlgis = 4;
            lektuvas2.VariklioTipas = "Propeleris";
            lektuvas2.VarikliuSkaicius = 1;

            Console.WriteLine(lektuvas1.Pavadinimas);
            Console.WriteLine(lektuvas2.SparnuIlgis);
            Console.WriteLine(lektuvas1.Klase);
            Console.WriteLine(lektuvas1.VariklioTipas);
            Console.WriteLine(lektuvas2.VarikliuSkaicius);

            Console.WriteLine();

            lektuvas1.Isvedimas();
            lektuvas2.Isvedimas();

            Console.WriteLine();

            Console.WriteLine(lektuvas1.VienasSparnas());
            Console.WriteLine(lektuvas2.VienasSparnas());

            Console.WriteLine(lektuvas1.KiekKeleiviu());
            Console.WriteLine(lektuvas2.KiekKeleiviu());

            Console.WriteLine();

            var lektuvas3 = new Lektuvas(5, "naikintuvas", 15, "naikinimo", 2, "reaktyvinis");
            lektuvas3.Isvedimas();

        }
    }
}
