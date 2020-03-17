using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Loopex1
    {
        static void Main(string[] args)
        {
            int i,j;
            for (i = 0; i < 5; i++) ;
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine(i+ " " +j);
                }
            }
            
            Console.Read();
        }
    }
}
