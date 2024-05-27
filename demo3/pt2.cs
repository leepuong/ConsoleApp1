using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demo3
{
    internal class pt2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" we have f(x) look like : ax^2 + by + c = 0");
            Console.WriteLine( " enter a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine(" enter b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(" enter c: ");
            double c = double.Parse(Console.ReadLine());

            double delta= (b * b) - 4 * a * c;
            /*delta = b * *(2) - 4 * a * c*/
            if (delta > 0)
            {
                /*x1 = (-b + delta * *(1 / 2)) / 2 * a*/
                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine("x1 = {0} \nx2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                /*x = (-b) / 2 * a*/
                double x = (-b) /2 * a;
                Console.WriteLine(" x = " + x);

            }
            else
            {
                Console.WriteLine("no result");
            }
            Console.ReadKey();
        }
    }
}
