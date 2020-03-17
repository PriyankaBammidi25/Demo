using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class Power
    {
        int i, n, a;
        double p=1;
        public void power1(int n)
        {
            for (i = 0; i <= n; i++)
            {
                if (n == 0)
                    Console.WriteLine(1);
                else
                {
                    p = p + 2;
                }
                a = a + 1;
            }
            Console.WriteLine(a);
        }

        class Mainpower
        {
            static void Main(string[] args)
            {
                Power P = new Power();
                P.power1(2,3);
                Console.Read();
            }
            
    }
    }
}
