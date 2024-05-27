using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class tam
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string st;



            Console.Write("nhaapj soso a : ");
            st = Console.ReadLine();
            a = int.Parse(st);

            Console.Write("nhaapj soso B : ");
            st = Console.ReadLine();
            b = int.Parse(st);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("so a :" + a);
            Console.WriteLine("so b :" + b);

            Console.ReadKey();



        }
    }
}
