using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace looklikePy
{
    internal class nguyento
    {
        static void Main(string[] args)
        {

            Console.Write("enter your number : ");
            int number = int.Parse(Console.ReadLine());

            Boolean nguyento = true;
            for (int i = 2; i < number; i = i++)
            {
                if (number % i == 0)
                {
                    nguyento = false;
                    break;
                }
                else
                {
                    break;
                }


            }
            Console.WriteLine();
            if (nguyento == true) {
                Console.WriteLine(number+" la so nguyen to");
            }
            else
            {
                Console.WriteLine(number +" k phair oso nguye nto");
            }
            Console.ReadKey();
        }
    }
}
