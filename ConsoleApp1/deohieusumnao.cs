using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class deohieusumnao
    {
        static void Main(string[] args)
        {
            int so1, so2, sum, diff;
            string st = Console.ReadLine();
            so1 = int.Parse(st);


            st = Console.ReadLine();
            so2 = int.Parse(st);

            sum = so1 + so2;
            diff = so1 - so2;
            Console.WriteLine("{0} + {1} = {2}", so1 ,so2, sum);
            Console.WriteLine("{0} - {1} = {2}", so1 ,so2, diff);
            Console.ReadKey();
        }

    }
}
