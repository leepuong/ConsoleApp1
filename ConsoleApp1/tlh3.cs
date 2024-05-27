using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class tlh3
    {
        static void Main(string[] args)
        {
            float toan, li, hoa, trung;
            string st;

            Console.Write("nhap toan : ");
            st = Console.ReadLine();
            toan = float.Parse(st);

            Console.Write("nhap li : ");
            st = Console.ReadLine();
            li = float.Parse(st);

            Console.Write("nhap hoa : ");
            st = Console.ReadLine();
            hoa = float.Parse(st);

            trung = (toan + li + hoa) / 3;

            Console.WriteLine("tong trung binh toan li hoa la " + trung);
            Console.ReadKey();

        }
    }
}
