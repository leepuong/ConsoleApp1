using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class drawMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("so hang : ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("so cot : ");
            int c = int.Parse(Console.ReadLine());

            for (int hang = 1; hang <= h; hang++)
            {
                for (int cot = 1; cot <= c; cot++)
                {
                    Console.Write("|A");
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
