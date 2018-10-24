using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); // randomas abiems variantams toks pat

            // pirmas variantas kai prima sukuriam masyva su jam rezervuotom vietom.
            var skaiciai = new int[5];

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rand.Next(100); //randoma generuojame for viduje
                Console.WriteLine("indekse {0} yra " + skaiciai[i],i);
            }
            Console.Write("random skaiciai: ");
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write(skaiciai[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
                Console.WriteLine("antraip");
            //atras, kiek letesnis, bet veikia, kai prima susikuriam random masyvo narius
            var a = rand.Next(100);
            var b = rand.Next(100);
            var c = rand.Next(100);
            var d = rand.Next(100);
            var e = rand.Next(100);

            var ciklas = new[] { a, b, c, d, e }; //turim savo nupiepusi masyva

            for (int i = 0; i < ciklas.Length; i++)
            {
                Console.WriteLine("indekse {0} yra " + ciklas[i],i);//ciklas, kuriame naudojamos turimos is anksciau reiksmes
            }
            Console.WriteLine("random skaiciai: {0} {1} {2} {3} {4}", a, b, c, d, e);

            Console.WriteLine();
            Console.WriteLine();
            
            }
        }
    }
