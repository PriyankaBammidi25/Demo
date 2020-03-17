using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class MTPattern
    {
        static void Main(string[] args)
        {
            int n = 10;
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if (j == 0 || j == n - 1)
                        Console.Write("*");
                    else if(i==j && i<=n/2)
                        Console.Write("*");
                    else if(i+j==n-1 && i<n/2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
