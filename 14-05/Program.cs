using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            pro.info("Jonas", "Bulveveidis", "IbhJ51", 8, 7, 6);
            Console.WriteLine("--");
            pro.info("Rimantas", "Nekrosius", "jv52d", 5, 6, 8);
        }
        public void studentas(string a, string b, string c)
        {
            Console.WriteLine("{0} {1} yra {2} grupes studentas", a, b, c);
        }
        public void pazymiai(int a, int b, int c)
        {
            Console.WriteLine("Jo(-s) vidurkis yra " + (a + b + c) / 3);
        }
        public void info(string a, string b, string c, int d, int e, int f)
        {
            studentas(a, b, c);
            pazymiai(d, e, f);

        }
    }
}
