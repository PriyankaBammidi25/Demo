using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Que4
    {
        public void reverse()
        {
            int i = int.Parse(Console.ReadLine());
            int s = i;
            int r, n = 0;
            
            while(i>0)
            {
                r = i % 10;
                n = n * 10 + r;
                i = i / 10;
            }
            int result = s - n;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Que4 Q = new Que4();
            Q.reverse();
            Console.Read();
        }
    }
}
