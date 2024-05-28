using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class lap1_ex4_backin30m
    {
        static void Main(string[] args)
        {
            int h, m;
            

            Console.Write("nhap gio : ");
            h = int.Parse(Console.ReadLine());
            Console.Write("nhap phut : ");
            m = int.Parse(Console.ReadLine());
            m = m + 30;
            if (h > 23){
                h = h - 24;
            }

            if (m > 59) 
            {
                m = m - 60;
                h = h + 1;
                if (h > 23)
                {
                    h = h - 24;
                }
            }
            
            

            Console.WriteLine("{0:D2}:{1:d2}", h, m);
            Console.ReadKey();
        }
    }
}
