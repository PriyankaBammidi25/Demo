using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class Mdemo
    {
        static void Main(string[] args)
        {
            int n = 7, i = n / 2 + 1;
            for (int a = 0; a <= n; a++)
            {
                //Console.WriteLine();
                Console.WriteLine("*");
            }
            Console.WriteLine("hi ");
            for (int a = 1; a < i; a++)
            {
                Console.WriteLine("hi ");
                for (int b = 1; b < i; b++)
                   Console.WriteLine(" ");
            }
            


            Console.Read();
        }
        
    }
}
