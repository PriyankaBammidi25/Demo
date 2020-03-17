using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Que3
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            string s1 = string.Empty;
           

            for (i =1; i < s.Length; i++)
            {
                if (s[i] == 'a')  
                {
                    if(i>0 && s[i - 1] != ' ')
                    s1 += s[i].ToString().ToUpper();
                    else
                        s1 += s[i].ToString().ToLower();

                }
                else if(i%2==0)
                {
                    s1 += s[i].ToString().ToUpper();
                }
                
                else
                {
                    s1 += s[i].ToString().ToLower();
                }
            }
            Console.WriteLine(s1);
            Console.Read();
        }
    }
}
