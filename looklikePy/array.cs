using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looklikePy
{
    internal class array
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.WriteLine("neter everything: ");
            a = Console.ReadLine();
            b = Console.ReadLine();

            string[] ab = { a, b };
            string soba = ab[0];
            Console.WriteLine(ab.Length);
            Console.WriteLine(soba);
            string[] dd = Console.ReadLine().Split(',');
            Console.WriteLine(dd.Length);
            Console.WriteLine(dd[dd.Length -2]);

            for (int i = 0; i < dd.Length; i++)
            {
                Console.WriteLine(dd[i]);
            }

            Console.ReadKey();
        }
    }
}
