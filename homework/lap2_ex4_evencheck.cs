using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap2_ex4_evencheck
    {
        static void Main(string[] args)
        {

            int n;
            
            do
            {
                Console.Write("input n :: ");
                n = int.Parse(Console.ReadLine());
                if (n% 2 !=0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else if (n < 0)
                {
                    n = -n;
                }

            }
            while (n % 2 != 0);
            Console.WriteLine("The number is: "+n);
            Console.ReadKey();



        }
    }
}
