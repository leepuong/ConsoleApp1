using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3
{
    internal class seconds
    {
        static void Main(string[] args)
        {

            Console.Write("in[ut of seconds: ");

            int sec = int.Parse(Console.ReadLine());
            int h = sec / 3600;
            int m = (sec % 3600) / 60;
            int s = (sec % 3600) % 60;
            Console.WriteLine("Yaaa~~ {0:d2}: {1:d2}: {2:d2} ",h,m,s);
            Console.ReadLine();



        }
    }
}
