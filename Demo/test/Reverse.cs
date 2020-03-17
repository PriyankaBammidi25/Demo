using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class Reverse
    {
        int n, rev = 0, a,b;
        public void Reverse1(int n)
        {
            b = n;
            while (n != 0)
            {
                
                a = n % 10;
                rev = rev * 10 + a;
                n = n / 10;
            }
           
            Console.Write(rev);
            Console.Write(b);
        }
         static void Main(string[] args)
          {
        Reverse R = new Reverse();
        R.Reverse1(87654321);
            
        Console.Read();
           
          }
        }
}
