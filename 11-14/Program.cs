using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pasirinkite, kiek Fibonaciaus skaiciu norite pamatyti: ");
            Console.WriteLine();
            var fibon = new List<int>();
            var kiek = Convert.ToInt32(Console.ReadLine());

            int pirmas = 1;
            int antras = 1;
            int trecias = pirmas + antras;

            for (int i = 2; i <= kiek; i++)
            {
                trecias = pirmas + antras;
                pirmas = antras;
                antras = trecias;
                Console.Write(trecias + " ");
                fibon.Add(trecias);
            }
            Console.WriteLine("--");
            foreach (var skaicius in fibon)
            {
                Console.Write(skaicius + ", ");
            }
        }
    }
}
