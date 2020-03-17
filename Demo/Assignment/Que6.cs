using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Que6
    {
        class Simplify
        {
            static void Main(string[] args)
            {
                string str = Console.ReadLine();
                Console.WriteLine(simplify(str));
                Console.ReadLine();

            }
            static string simplify(string s)
            {

                string[] c = s.Split('/');
                int num1 = int.Parse(c[0]);
                int num2 = int.Parse(c[1]);
                int k;
                if (num1 < num2)
                    k = num1;
                else
                    k = num2;
                int h = 1;
                for (int i = 2; i <= k; i++)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        h = i;
                        //break;
                    }

                }
                num1 = num1 / h;
                num2 = num2 / h;
                if (num2 == 1)
                    return num1.ToString();
                else
                    return num1 + "/" + num2;
            }
        }
    }
}
