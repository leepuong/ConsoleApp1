using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class rectangel
    {   
        static void Main(string[] args)
        {
            int dai, rong, per, area;
            Console.Write("nhap chieu dai : ");
            string st = Console.ReadLine();
            dai = int.Parse(st);

            Console.Write("nhap chieu rong : ");
            st = Console.ReadLine();
            rong = int.Parse(st);

            per = (dai + rong) * 2;area = dai * rong;
            Console.WriteLine("chu vi cua hinh chua nhat co dai {0} va rong {1} la {2}", dai, rong, per);
            Console.WriteLine("dien tich cua hinh chua nhat co dai {0} va rong {1} la {2}", dai, rong, area);

            Console.ReadKey();  
        }
    }
}
