using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var medziai = new[] { "obelis", "liepa", "berzas", "azuolas", "drebule", "klevas" };

            for (int i = 0; i < medziai.Length; i++)
            {
                Console.WriteLine("-" + medziai[i]);
            }
        }
    }
}
