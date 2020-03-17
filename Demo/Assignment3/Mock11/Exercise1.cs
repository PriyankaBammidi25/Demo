using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2.Mock11
{
    class Exercise1: IEnumerable<int>
    {
        public static int Poly(int x, IEnumerable<int> coeffs)
        {
            int t = 0;
            int f = 0;
            foreach (var i in coeffs)
            {
                t = t + f *i;
                f = f * x;
            }
            return t;

        }
        static void Main(string[] args)
        {
            IEnumerable<int> coeffs = new List<int> { 3, 4, 5 };
            // t = coeffs.Aggregate(2, coeffs);
            Console.WriteLine(Poly(2, coeffs));
            Console.ReadLine();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
