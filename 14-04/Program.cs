using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.lygybe(21/4,14);
            p.lygybe(18/2,1);
            p.lygybe(12*4,40+8);
            p.lygybe(11,11);
        }
        public void lygybe(int a, int b)
        {
            if (a>b)
            {
                Console.WriteLine("{0} > {1}",a,b);
            }
            else if (a<b)
            {
                Console.WriteLine("{0} > {1}", a, b);
            }
            else
            {
                Console.WriteLine("Skaiciai lygus");
            }
        }
    }
}
