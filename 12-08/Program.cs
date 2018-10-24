using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new List<string>();
            vardai.Add("Tomas");
            vardai.Add("Robertas");
            vardai.Add("Jeroslavas");
            vardai.Add("Ula");
            vardai.Add("Mykolas");
            vardai.Add("Robert");

            int kiek_ilgiausias = vardai[0].Length;
            var ilgiausias = 0;
            int kiek_trumpiausias = vardai[0].Length;
            var trumpiausias = 0;

            foreach (var vardas in vardai)
            {
                Console.Write("varde raidziu " + vardas.Length);
                Console.WriteLine(" - " + vardas);
            }
            Console.WriteLine("--");
            foreach (var vardas in vardai)
            {
                if (kiek_ilgiausias < vardas.Length)
                {
                    kiek_ilgiausias = vardas.Length;
                    ilgiausias = vardai.IndexOf(vardas);
                }
                if (kiek_trumpiausias > vardas.Length)
                {
                    kiek_trumpiausias = vardas.Length;
                    trumpiausias = vardai.IndexOf(vardas);
                }
            }

            Console.WriteLine("ilgiausias vardas " + vardai[ilgiausias] + " susidedantis is " + kiek_ilgiausias + " raidziu.");
            Console.WriteLine("trumpiausias vardas " + vardai[trumpiausias] + " susidedantis is " + kiek_trumpiausias + " raidziu.");
        }
    }
}
