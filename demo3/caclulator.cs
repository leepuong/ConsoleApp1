using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class caclulator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a :");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter b :");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("+-*/");
            string phet = Console.ReadLine();

            switch (phet)
            {
                case "+":
                    {
                        Console.WriteLine(a + b);break;
                    }
                case "-":
                    {
                        Console.WriteLine(a - b); break;
                    }
                case "*":
                    {
                        Console.WriteLine(a * b); break;
                    }
                case "/":
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("b k dc = 0");
                        }
                        else
                        {

                        Console.WriteLine(a / b);
                        }
                        break;
                    }
                default: { Console.WriteLine("i dont know man");break; }
            }
        }
    }
}
