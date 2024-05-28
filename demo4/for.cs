using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, s = 0;
            Console.Write("input n : ");
            int n = int.Parse(Console.ReadLine());
            for (i = 1; i<= n; i = i + 2)
            {
                s = s + i;
                Console.WriteLine("tong la "+s);
            }
            Console.ReadKey();
        }
    }
}
