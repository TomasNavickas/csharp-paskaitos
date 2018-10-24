using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_01
{
    class Program
    {
        public void eilerastis()
        {
            Console.WriteLine("Mano batai buvo du \nvienas dingo nu ir kas");
        }

        static void Main(string[] args)
        {
            var programa = new Program();
            programa.eilerastis();
            Console.WriteLine();
            Console.WriteLine("antras eilerastis");
            Console.WriteLine();
            programa.antras_eilerastis();
        
        }
        public void antras_eilerastis()
        {
            Console.WriteLine("O gi tas, kad \nlabai salta ir slapia. :( ");
        }
    }
}
