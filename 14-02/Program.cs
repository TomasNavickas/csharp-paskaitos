using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            pro.sakinys("Petras", "Jonauskas", 30, "kikimara");
            pro.sakinys("Antanas", "Geruliausias", 72, "nieko neveikti");

        }
        public void sakinys(string z, string s, int a, string p)
        {
            Console.WriteLine("{0} {1} yra {2}m. amziaus ir jo darbas {3}", z, s, a, p);
        }
    }
}
