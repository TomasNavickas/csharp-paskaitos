using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var knygynas = new Knygynas("Pegasas", "Savanoriu pr. 60, Kaunas", new List<Knyga>
            {
                new Knyga("Haris Poteris","J.K. Rowling", 604, "fantastika", 30.99, 5, 10.11),
                new Knyga("Pasauliu Karas","Stewhen King", 464, "siaubo", 37.84, 7 ,13.14),
                new Knyga("Liaudies pasakos","S. Neris", 187, "vaikams", 19.95, 24, 5.1),
                new Knyga("Vakaru Ekspresas","B. Jones", 351, "detektyvas", 21.9, 12, 7.01),
                new Knyga("Fizina musu namuose","S.H. Krebler", 324, "mokslas", 49.99, 20, 14.11),
            });

            knygynas.Isvedimas();
        }
    }
}
