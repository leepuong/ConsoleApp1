using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class dayofthemonth
    {
        static void Main(string[] args)
        {
            Console.Write( "enter month:  ");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        Console.WriteLine( "31 days");
                        break;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        Console.WriteLine("30 days");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("enter year");
                        int year = int.Parse(Console.ReadLine());
                        if (year % 4 == 0 && year % 100 != 0)
                        {
                            Console.WriteLine("29 days");
                        }
                        else
                        {
                            Console.WriteLine("28 days");
                        }
                        break;
                    }
                default: Console.WriteLine("Error!");break;

            }
            Console.ReadLine();
        }
        
    }
}
