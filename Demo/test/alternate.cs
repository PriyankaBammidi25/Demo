using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class alternate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i=0, even=0, odd=0,a;
            while (n>1)
            {
                a = n % 10;
                if (i % 2 == 0)
                    even = even + a;
                else
                    odd = odd + a;
                    n = n / 10;
                     i++;
            }
            if (even == odd)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");
            Console.Read();
        }
    }
}
