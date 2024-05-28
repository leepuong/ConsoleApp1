using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4
{
    internal class dowhile
    {
        static void Main(string[] args)
        {
            int pass = 108526, p,i=0;
            do
            {
                Console.WriteLine("enter pass :: ");
                p = int.Parse(Console.ReadLine());
                i++;
                if (i >= 3)
                {
                    break;
                }
                
                
            }
            while( p != pass );
            if (i >= 3)
                {
                    Console.WriteLine("wrong the pass");
                    Console.ReadKey();
                    
                }
            else
            {
                Console.WriteLine("yaa~~");

            }
            Console.ReadKey();




            
        }
    }
}
