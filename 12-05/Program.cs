using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kiek vardu norite ivesti?");
            Console.WriteLine();
            var kiek = Convert.ToInt32(Console.ReadLine());
            var vardai = new List<string>();
            var viso = 0;
            do
            {
                string vardas = Console.ReadLine();
                vardai.Add(vardas);
                viso++;
            } while (viso != kiek);

            Console.WriteLine("pirmas vardas " + vardai[0]);
            Console.WriteLine("paskutinis vardas " + vardai.Last());
            Console.WriteLine();
        }
    }
}
