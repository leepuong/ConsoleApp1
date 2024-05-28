using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class factorial
    {
        static void Main(string[] args)
        {
            int i, s = 1, n;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                s = s * i;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
