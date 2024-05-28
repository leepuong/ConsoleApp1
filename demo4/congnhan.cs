using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class congnhan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input ng : ");
            int s=0, p=1 ;
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                p = p * i;
                s = s + p;

            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
