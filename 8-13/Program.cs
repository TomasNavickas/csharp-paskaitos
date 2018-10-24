using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite iki kokio fibonaciaus skaiciaus norite gauti seka:");
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
            }
        }
    }
}
