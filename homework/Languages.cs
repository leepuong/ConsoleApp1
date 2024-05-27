using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Languages
    {
        static void Main(string[] args)
        {
            Console.Write("enter name of country : ");
            string a = Console.ReadLine();
            switch (a){
                
                case "USA":
                case "England":
                    {
                    Console.WriteLine("english");
                    break;
                    }

                case "Argentine":
                case "Mexico":
                case "Spain":
                    {
                    Console.WriteLine("Spanish ");
                    break;
                    }

                default:
                    {
                    Console.WriteLine("unknown");
                    break;
                    }

            }
            Console.ReadKey();


        }
    }
}
