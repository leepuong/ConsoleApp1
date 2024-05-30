using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap2_ex6_pattenWithNumber
    {
        static void Main(string[] args)
        {
            Console.Write("input number :: ");
            int n = int.Parse(Console.ReadLine());

            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                string x = "";
                for (int j = 1;j <= s; j++)
                {
                    x = x + " " +j;
                }
                Console.WriteLine(x);
                s++;

            }
            Console.ReadLine();
            
            
            
            
            
            
            

            
          
        }
    }
}
