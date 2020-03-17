using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Que60
    {
        public void GCD()
        {
            int gcd=0;
            string num = Console.ReadLine();
            string[] s1 = num.Split('/');
            //Console.WriteLine(s1[i]);
            int a = int.Parse(s1[0]);
            int b = int.Parse(s1[1]);
            for(int i=1;i<=a&&i<=b;i++)
            {
                if(a%i==0&&b%i==0)
                {
                    gcd = i;
                }
            }
            Console.WriteLine(gcd);
            
           // int a=int.
            //if(s1[i])

        }
        static void Main(string[] args)
        {
            
            Que60 Q = new Que60();
            Q.GCD();
            Console.Read();
        }
    }
}
