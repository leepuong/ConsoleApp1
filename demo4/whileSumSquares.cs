using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class whileSumSquares
    {   
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0, s = 0;

            while ( i <= n)
            {
                s = s + (i * i);
                i++;
            }
            Console.WriteLine("yaa~~~" + s);
            Console.ReadLine();
        }
    }
}
