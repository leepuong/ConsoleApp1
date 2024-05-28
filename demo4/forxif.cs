using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class forxif
    {
        static void Main(string[] args)
        {
            System.Console.Write("input n : ");
            int n = int.Parse(Console.ReadLine());
            int i, s = 0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    s = s + i;
                }

            }
            Console.WriteLine("tong la : " + s);
            Console.ReadKey();
        }
    }
}
