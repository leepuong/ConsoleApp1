using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap1_ex3_failed
    {
        static void Main(string[] args)
        {
            Console.Write("enter your graed : ");
            double a = double.Parse(Console.ReadLine());

            if (a <= 3)
                Console.WriteLine("Failed!");
            else
                Console.WriteLine("Passed!");




            Console.ReadKey();
        }
    }
}
