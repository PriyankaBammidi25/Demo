using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Concat1
    {
        static void Main(string[] args)
        {
            int i, j=0;
            string[] a = new string[] { "aa", "bb", "cc" };
            string[] b = new string[] { "aa", "dd", "ee" };
            string[] c = null;
            for( i=0;i<a.Length;i++)
            {
                for( i=0;i<b.Length;i++)
                {
                    for ( j = 0; j < c.Length; j++)
                    {
                        if (a[i] == b[i])
                            c[j] = c[j] + a[i];
                        else
                            c[j] = c[j] + b[i];
                    }
                }
            }
            Console.WriteLine(c[j]);
            Console.Read();
        }
    }
}
