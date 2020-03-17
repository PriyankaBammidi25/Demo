using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Ifexp1
    {
        static void Main(string[] args)
        {
            int i = 1;
            if (i < 5)
            {
                Console.WriteLine(" I is greater than 5");
                Console.WriteLine(" I is greater than 5");
            }
            else if (i > 70)
                Console.WriteLine("pass");
            else
                Console.WriteLine();

            Console.Read();
        }
        
    }
}
