using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class whileFactor
    {
        static void Main(string[] args)
        {
            int i = 1, s = 1, n;
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                s = s * i;
                i++;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
