using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap2_ex1_SumNOdds
    {
        static void Main(string[] args)
        {
            int s = 0,p;
            Console.Write("input n of odd numbers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("__________________________");

            for (int i = 0; i <n; i++)
            {
                p = i * 2 + 1;
                s += p;
                Console.WriteLine(p);

            }
            Console.Write("yaa~");
            Console.Write(s);
            Console.ReadKey ();
        }
    }
}
