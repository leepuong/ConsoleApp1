using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class lim
    {
        static void Main(string[] args)
        {
            int i, n;
            double s = 0;
            n = int.Parse(Console.ReadLine());  
            for (i = 1; i <= n; i++)
            {
                s += 1.0 / i;
                Console.Write("{0}+",s);

            }
            Console.WriteLine("yaa~~~" + s);
            Console.WriteLine("1/2n");
            for (i = 0; i >= n; i++)
            {
                s += 1.0 / i * 2;

            }
            Console.WriteLine("yaaa~~~"+s);
            Console.WriteLine("1/(2n+1)");
            for (i = 0; i >= n; i++)
            {
                s += 1.0 / (2 * i + 1);
            }
            Console.WriteLine("yaaa~~~" +s);
            Console.ReadKey();



            

        }
        

        
    }
}
