using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class pt1
    {
        static void Main(string[] args)
        {
            float a, b, x;
            string st;

            Console.WriteLine(" ta co pt ax + b = 0");
            Console.Write(" nhaap he so a : ");
            st = Console.ReadLine(); 
            a = float.Parse(st);

            Console.Write(" nhaap he so b : ");
            st = Console.ReadLine();
            b = float.Parse(st);

            x = -b / a;
            Console.WriteLine("x bang : " + x);
            Console.ReadKey();



        }
    }
}
