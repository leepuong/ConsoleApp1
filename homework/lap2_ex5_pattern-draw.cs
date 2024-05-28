using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap2_ex5_pattern_draw
    {
        static void Main(string[] args)
        {

            Console.Write("day : ");
            int d = int.Parse(Console.ReadLine());
            int k = 0;

            for(int i = 0; i < d; i++)
            {
                string x = ".";
                for(int j = 0;j <= k; j++)
                {
                    x += " *";
                }
                Console.WriteLine(x);
                k++;
            }
            Console.ReadLine();

        }
    }
}
