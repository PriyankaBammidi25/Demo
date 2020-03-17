using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Que1
    {
        public void func()
        {
            int n;
            char c;
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string str =string.Empty ;
            for(int i=0;i<s.Length;i=i+2)
            {

                str = string.Empty;
                c = s[i];
                n = int.Parse(s[i + 1].ToString());
                for(int j=1;j<=n;j++)
                {
                    str = str + c;
                }
                Console.Write(str);
            }
            
        }
        static void Main(string[] args)
        {
            Que1 Q = new Que1();
            Q.func();
            Console.Read();
        }
    }
}
