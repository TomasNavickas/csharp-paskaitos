using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
            pro.zodziai("ananasas");
            pro.zodziai("pomidoras");
            pro.zodziai("kriaukle");
            pro.zodziai("makaronai");
            pro.zodziai("saukstas");
            pro.zodziai("nenoriu");
        }
        public void zodziai(string z)
        {
            Console.WriteLine("--{0}--", z);
        }
    }
}
