using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap2_ex6_pattenOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input s");
            int n = int.Parse(Console.ReadLine());
            int step = 1;
            for (int i = 1; i <= n; i++)
            {
                string x = "";
                for (int j = 1;j <= step; j++)
                {
                    x = x + j;
                }
                Console.WriteLine(x);
                step++;

            }
            Console.ReadLine();
            
            
            
            
            
            
            

            
          
        }
    }
}
