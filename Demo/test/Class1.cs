using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class Class1
    {
        public void Func1()
        {
            int a = 2;
            int i = int.Parse(Console.ReadLine());
            while(i>1)
            {
                i = i / 2;
                a = a * 10 + 2;
            }
            a = a - 1;
            Console.WriteLine(a);
        }
        class Mainclass
        {
            static void Main(string[] args)
            {
                Class1 C = new Class1();
                C.Func1();
                Console.Read();
            }
        }
    }
}
