using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class maxelse
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "nhap a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine( "nhap b ");
            int b = int.Parse(Console.ReadLine());

            

            if (a > b)
            {
                Console.WriteLine("max is"+ a);
            }
            else
            { Console.WriteLine("max is " + b); }

            Console.ReadKey();
        }
    }
}
