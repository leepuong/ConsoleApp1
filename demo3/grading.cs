using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class grading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter grade point");
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 0 && grade <=10 )
            {
                if (grade >= 9)
                {
                    Console.WriteLine("Excellent");
                }
                else if (grade >=8)
                {
                    Console.WriteLine("Good");
                }
                else if (grade >= 6)
                {
                    Console.WriteLine("Medium");
                }
                else if (grade >= 5)
                {
                    Console.WriteLine("Average");
                }
                else
                {
                    Console.WriteLine("Weak");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.ReadKey();
        }
    }
}
