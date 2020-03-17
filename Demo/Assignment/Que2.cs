using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Que2
    {
        public void Func1()
        {
            int a = 2;
            int i = int.Parse(Console.ReadLine());
            while (i > 1)
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
                Que2 C = new Que2();
                C.Func1();
                Console.Read();
            }
        }
    }
}
