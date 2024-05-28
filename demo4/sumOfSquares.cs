using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class sumOfSquares
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i, s = 0;

            for (i = 0; i <= n; i+=2)
            {
                s = s + (i*i);
            }
            Console.WriteLine("yaa~~~" + s);
            Console.ReadLine();

        }
        
        
    }
}
