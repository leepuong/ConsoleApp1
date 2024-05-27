using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class ticket
    {
        static void Main(string[] args)
        {
            Console.Write("when : ");
            string day = Console.ReadLine();
            

            Console.Write("your age : ");
            int age = int.Parse(Console.ReadLine());


            switch (day)
            {
                case "weekday":
                    if (0 <= age && age <= 18)
                        Console.WriteLine("15$");
                    else if (18 < age && age <= 64)
                        Console.WriteLine("20$");
                    else if (64 < age && age <= 122)
                        Console.WriteLine("15$");
                    else
                        Console.Write("you are alien! your age!");
                    break;


                case "weekend":
                    if (0 <= age && age <= 18)
                        Console.WriteLine("15$");
                    else if (18 < age && age <= 64)
                        Console.WriteLine("20$");
                    else if (64 < age && age <= 122)
                        Console.WriteLine("15$");
                    else 
                        Console.Write("you are alien! your age!");
                    break;


                case "holiday":
                    if (0 <= age && age <= 18)
                        Console.WriteLine("15$");
                    else if (18 < age && age <= 64)
                        Console.WriteLine("20$");
                    else if (64 < age && age <= 122)
                        Console.WriteLine("15$");
                    else
                        Console.Write("you are alien! your age!");
                    break;


                default:
                    Console.WriteLine("Error! wwhat wrong with you, wwhat the puck '{0}'",day);
                    break;

            }

            Console.ReadKey();
        }
    }
}
