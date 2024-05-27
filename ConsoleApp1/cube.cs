using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class cube
    {
        static void Main(string[] args)
        {
            int a, sq, cube;
            string st;

            Console.WriteLine("nhap a : ");
            st = Console.ReadLine();
            a = int.Parse(st);

            sq = a * a;
            cube = a * a * a;
            Console.WriteLine("binh cua {0} laf {1} \nlap cua {0} laf {2}",a , sq, cube); 
            Console.ReadKey();

        }
    }
}
