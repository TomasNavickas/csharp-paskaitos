using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var pro = new Program();
                pro.metodas();
        }
        public void metodas()
        {
            var listas = new List<string>();
            listas.Add("pirmas");
            listas.Add("antras");
            listas.Add("trecias");
            listas.Add("ketvirtas");
            listas.Add("penktas");
            listas.Add("sestas");
            foreach (var item in listas)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
}
