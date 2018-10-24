using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentai = new[] { "Tomas", "Petras", "Albinas", "Jonas" };
            var i = 0;
            var j = 0;
            Console.WriteLine("+-----------+-------+");
            Console.WriteLine("| Studentas | Index |");
            foreach (var studentas in studentai)
            {
                Console.WriteLine("+-----------+-------+");
                Console.WriteLine("|{0,-10} | {1,-6}|", studentai[i], j);
                j++;
                i++;
            }
            Console.WriteLine("+-----------+-------+");

        }
    }
}
