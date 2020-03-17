using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j;
            //accept the data in console app
            //implicit conversion or boxing
            i = int.Parse(Console.ReadLine());
            //explicit or unboxing
            int k, l;
            k =  (int)double.Parse(Console.ReadLine());
            long m;
            m = (long)double.Parse(Console.ReadLine());
            l = (int)long.Parse(Console.ReadLine());
            double n;
            n = double.Parse(Console.ReadLine());
            Console.WriteLine(i);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine(l+":"+ "hi");
            Console.WriteLine(n);
            Console.Read();
        }
    }
}
