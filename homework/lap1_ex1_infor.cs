using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap1_ex1_infor
    {
        static void Main(string[] args)
        {
            string name, st;
            int age;
            float grade;


            Console.Write("enter your name : ");
            name = Console.ReadLine();

            Console.Write("enter your age : ");
            st = Console.ReadLine();
            age = int.Parse(st);

            Console.Write("enter grade : ");
            st = Console.ReadLine() ;
            grade = float.Parse(st);

            Console.WriteLine("Name : {0}, Age : {1}, Grade : {2}", name, age ,grade);
            Console.ReadKey();


        }
    }
}
