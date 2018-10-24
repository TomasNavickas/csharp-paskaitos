using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_001
{
    class Knygynas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Knyga> Knygos { get; private set; }

        public Knygynas(string pavadinimas, string adresas, List<Knyga> knygos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Knygos = knygos;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Knygyno pavadinimas: " + Pavadinimas);
            Console.WriteLine("Ji rasti galima: " + Adresas);
            Console.WriteLine("------");
            Console.WriteLine("Jame galima rasti knygu: ");
            Console.WriteLine("----------------");

            foreach (var knyga in Knygos)
            {
                knyga.Isvedimas();
            }
            Console.WriteLine();
            Console.WriteLine("--------------------");

            Console.WriteLine("Didziausia knyga:");
            var didziausia = DidziausiaKnyga();
            DidziausiaKnyga().Isvedimas();

            Console.WriteLine("---------------");

            Console.WriteLine("Didziausia knyga:");
            DidziausiaKnyga().Isvedimas();

            Console.WriteLine("----");

        }
        public Knyga DidziausiaKnyga()
        {
            var didziausia = Knygos.First();

            foreach (var knyga in Knygos)
            {
                if (knyga.Puslapiai > didziausia.Puslapiai)
                {
                    didziausia = knyga;
                }
            }
            return didziausia;
        }
        public double BendraApyvarta()
        {
            // rasti bendra visu knygu apyvarta
            // ant kiekvienos knygos naudojant apyvartos metoda is knygos klases
            var apyvarta = 0.0;
            foreach (var knyga in Knygos)
            {
                apyvarta += knyga.Apyvarta();
            }

            return apyvarta;
        } 
    }
}
// parasyti
// - brangiausia knyga
// - pigiausia knyga 
// bendras puslapiu skaicius visu knygu
// - kainos vidurkis