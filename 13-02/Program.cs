using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            pro.policininkas();
        }
        public void policininkas()
        {
            var vardas = "Jonas";
            var pavarde = "Petrauskas";
            var amzius = 34;
            var alga = 1000; // eur/men
            var etatas = 1.25;
            var specializacija = "kriminalistas";
            Console.WriteLine("{0} dirba policininku, kam yra {1}m.. {0} {2} uzdirba tik {3}e/men, nors dirba {4}etatu,\no jo specializija yra {5}", vardas, amzius, pavarde, alga, etatas, specializacija);
        }
    }
}
