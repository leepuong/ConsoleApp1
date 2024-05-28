using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("foreah ex");
            int[] intArr = new int[10];
            Random r = new Random();

            for (int idx = 0; idx < 10; idx++)
            {
                intArr[idx] = r.Next(1,10);
            }
            Console.WriteLine("value of elme");
            foreach (int val in intArr)
            {
                Console.WriteLine(val+" ");
            }

            Console.ReadKey();
        }
    }
}
