using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class equalsornot
    {
        static void Main(string[] args)
        {
            Console.Write("input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("input b: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a lon hon b");
            }
            else if (b > a)
            {
                Console.WriteLine("b lon hon a");
            }
            else
            {
                Console.WriteLine("a bang b");
            }
            Console.ReadKey();
            Console.ReadKey();


        }
    }
}
