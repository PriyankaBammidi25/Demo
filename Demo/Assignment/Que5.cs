using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Que5
    {
        public int PowerRange(int n,int a,int b)
        {
            int i = 1;
            int count = 0;
            while (i < b)
            {
                int p = (int)Math.Pow(i, n);
                if (p >= a && p <= b)
                {
                    count++;
                }

                i++;

            }
            return count;
        }
        static void Main(string[] args)
        {
            int r;
            Console.WriteLine("Enter numbers");
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Que5 Q = new Que5();
            r = Q.PowerRange(n, a, b);
            Console.WriteLine(r);
            Console.Read();

        }
    }
}
