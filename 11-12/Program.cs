using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var kilometrai = new[] { 15, 20, 140, 90, 84, 30 };
            var greitis = 34.5; //km/h
            var benzas = 1.14; //eur/l
            var sanaudos = 7; //l/100km
            var kelione = kilometrai.Sum();
            var kaina = kelione * benzas * sanaudos;
            var trukme = kelione / greitis;
            Console.WriteLine("viso nuvaziuota: " + kelione);
            Console.WriteLine("viso kainavo kelione: " + kaina);
            Console.WriteLine("kelione truko:" + trukme);


        }
    }
}
