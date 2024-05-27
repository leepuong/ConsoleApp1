using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class piLao
    {
        static void Main(string[] args)
        {
            double r, cv, s;
            double pi = 3.1415926535897931;
            string st;
            Console.Write("nhap r : ");
            st = Console.ReadLine();
            r = float.Parse(st);

            cv = 2 * pi * r;
            s = pi * r * r;

            Console.WriteLine("chu vi la : {0} va dien tich la : {1}", cv, s);
            Console.ReadKey();

        }

    }
}
