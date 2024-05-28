using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap1_ex2_passed
    {
        static void Main(string[] args)
        {
            double a;
            string st;

            Console.WriteLine("enter a grade : ");
            st = Console.ReadLine();
            a = double.Parse(st);
            if (a >= 3)
                Console.WriteLine("Passed!");
            else
                Console.WriteLine("...");
            Console.ReadKey();
        }
    }
}
