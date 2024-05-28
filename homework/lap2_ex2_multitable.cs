using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap2_ex2_multitable
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("input n :: ");
            n = int.Parse(Console.ReadLine()); 
            if (n <=100 && n >= 0)
            {
                for (i = 1; i <= 10; i++)
                {
                Console.WriteLine("{0:d2} * {1:d2} = {2:d2}",n, i, n*i);
                }

            }
            else
            {
                Console.WriteLine("n is wrong");
            }
            
            Console.ReadKey();


        }
    }
}
