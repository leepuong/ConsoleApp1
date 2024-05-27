using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class lúa
    {
        static void Main(string[] args)
        {
            int hour, salary, total;
            string st; 

            Console.WriteLine("nhap so gio lam : ");
            st = Console.ReadLine();
            hour = int.Parse(st);

            Console.WriteLine("nhap luong : ");
            st = Console.ReadLine();
            salary = int.Parse(st);

            total = hour * salary;

            Console.WriteLine("so lua ban nhan la " + total);
            Console.ReadKey();



        }
    }
}
