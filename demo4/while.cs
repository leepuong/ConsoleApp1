using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class @while
    {
        static void Main(string[] args)
        {
            int n, i = 1;
            n = int.Parse(Console.ReadLine());
            while (i<=10)
            {
                Console.WriteLine("{0} * {1} = {2}",n,i,n*i);
                i++;
            }
            Console.ReadKey();  
        }
    }
}
