using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string st;
            Console.WriteLine("nhap a : ");
            st = Console.ReadLine(); 
            a = int.Parse(st);
            for (int i = 1; i <= 10; i = i + 1) 

            
            Console.WriteLine("{0} * {1} = {2}", i, a ,a*i);
            Console.ReadKey();  
            
        }
    }
}
