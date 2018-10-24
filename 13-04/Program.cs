using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.pasisveikinimas();
        }
        public void pasisveikinimas()
        {
            Console.WriteLine("Iveskite savo varda");
            var vardas = Console.ReadLine();
            Console.WriteLine("Labas vakaras, gerb. " + vardas);
        }
    }
}
