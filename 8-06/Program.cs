using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iveskite reziu pradzia: ");
            var pra = Convert.ToInt64(Console.ReadLine());
            Console.Write("iveskite reziu pabaiga: ");
            var pab = Convert.ToInt64(Console.ReadLine());

            if (pra < pab)
            {
                for (int i = 0; i <= pab; i++)
                {
                    if (i % 8 == 0 || i % 2 != 0)
                    {
                        Console.WriteLine("{0} nelyginis arba dalinasi is 8",i);
                    }
                    else
                        continue;
                }
            }
            else
	            {
                Console.WriteLine("iveskite logiskus rezius");
                }
            }
        }
    }


