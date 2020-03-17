using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.pattern
{
    class Demo
    {
        static void Main(string[] args)
        {
            int n = 5;
            char ch = '*';
            int i = n / 2, j = 1;
            for (int a = 0; a <=n/2; a++) //row 0;i=3 j=1
            {      
                for (int c = 0; c < i; c++) //i=3 c=1 c=2
                    {
                        Console.Write( " ");
                    }
                   
                    for (int d = 0; d < j; d++) //j=1 0<1 print *
                    {
                        Console.Write("*");
                    }
                i--; //2=i after last iteration i=-1,j=9
                j = j + 2; //j=3;
                Console.WriteLine();
            }
            i = 1;
            j = n - 2; //j=5
            for (int a = 0; a < n; a++)
            {
                for (int c = 0; c < i; c++) //c=0,i=1
                {
                    Console.Write(" ");
                }

                for (int d = 0; d < j; d++) //d=0,j=5
                {
                    Console.Write("*");
                }
                i++; //2=i
                j = j - 2; //j=3
                Console.WriteLine();
            }
                Console.Read();
        }
    }
}

