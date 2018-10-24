using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek pazymiu norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("suveskite:\n");
            var pazymiai = new List<double>();
            var rand = new Random();
            for (int i = 0; i < kiek; i++)
            {
                var skaicius = Convert.ToDouble(Console.ReadLine());
                pazymiai.Add(skaicius);
            }
            Console.WriteLine("didziausias " + pazymiai.Max());
            Console.WriteLine("maziausias " + pazymiai.Min());
            Console.WriteLine("vidurkis " + pazymiai.Average());
            Console.WriteLine("atsitiktinis " + pazymiai[rand.Next(kiek-1)]);
            // susikuriam kintamaji ant kurio skaiciuotu kiek yra desimtuku
            var desimtukai = 0;
            foreach (var sk in pazymiai)
            {
                if (sk == 10)
                {
                    desimtukai++;
                }
            }
            Console.WriteLine("kiek desimtuku " + desimtukai);
            var ketvirtukai = 0;
            foreach (var sk in pazymiai)
            {
                if (sk == 4)
                {
                    ketvirtukai++;
                }
            }
            Console.WriteLine("kiek ketvirtuku " + ketvirtukai);
        }
    }
}
