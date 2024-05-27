using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class max
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap b");
            int b = int.Parse(Console.ReadLine());

            int max = a;

            if (a < b)
            {
                max = b;
            }
            Console.WriteLine(max);
            Console.ReadKey();


        }
    }
}
