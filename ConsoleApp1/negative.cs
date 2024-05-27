using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class negative
    {
        static void Main(string[] args)
        {
            int a, b;
            string st;

            Console.Write("nhap a : ");
            st = Console.ReadLine(); 
            a = int.Parse(st);

            Console.Write("nhap b : ");
            st = Console.ReadLine();
            b = int.Parse(st);

            if (a > b )
                Console.WriteLine("a lonw nhat");
            else
                Console.WriteLine("b lonw hhat");
            Console.ReadKey();

        }
    }
}
