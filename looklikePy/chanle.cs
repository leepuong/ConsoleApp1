using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looklikePy
{
    internal class chanle
    {
        /*Sử dụng câu lệnh If else để in ra các đề bài như sau
       Nếu N là số lẻ, in ra "Weird".
       Nếu N là số chẵn và nằm trong khoảng từ 2 đến 5 (bao gồm cả 2 và 5), in ra "Not Weird".
       Nếu N là số chẵn và nằm trong khoảng từ 6 đến 20 (bao gồm cả 6 và 20), in ra "Weird".
       Nếu N là số chẵn và lớn hơn 20, in ra "Not Weird".*/
        static void Main(string[] args)
        {
            Console.WriteLine("enter number : ");
            int number = int.Parse(Console.ReadLine());
            if (number %2 == 0 && number <= 5 && number >= 2) {
                Console.WriteLine("not weird");
            }
            else if (number % 2 == 0 && number > 5 && number <=20) { 
                Console.WriteLine("weird");
            }
            else if (number % 2 != 0 )
            {
                Console.WriteLine("weird");
            }
            else
            {
                Console.WriteLine("not weird");
            }
            Console.ReadKey();
        }
    }
}
