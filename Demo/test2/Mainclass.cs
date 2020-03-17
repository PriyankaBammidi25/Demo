using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test2
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Book B = new Book();
            B.INPUT(10,"Scholar",200);
            B.PURCHASE();
            Console.Read();
        }
    }
}
