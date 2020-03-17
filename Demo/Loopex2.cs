using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Loopex2
    {
        static void Main(string[] args)
        {
            int i=0;
            while(i<5)
            {
                int j = 0;
                while(j<5)
                {
                   
                    Console.WriteLine(i+ " " +j);
                    j++;
                }
                //Console.WriteLine(i);
                i++;
            }
            Console.Read();
        }
    }
}
