using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class minmaxabc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap a :");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("nhap b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap c :");
            int c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " max");
                }
                else
                {
                    Console.WriteLine(c + "max");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b + "max");
                }
                else 
                { 
                    Console.WriteLine(c + "max");
                }
            }
            Console.ReadKey();
        }
    }
}
