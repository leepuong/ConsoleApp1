using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class leapyear
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (year%4 == 0 && year %100 !=0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("no is not leap year");
            }
            Console.ReadKey();
        }
    }
}
