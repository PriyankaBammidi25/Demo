using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2.Mock11
{
    class Exercise
    {
        public static int poly(int x,IEnumerable<int> coeffs)
        {
            int cnt = coeffs.Count();

            int Result = coeffs.Aggregate(0,(Total,n)=>
            {
                int c = (int)Math.Pow(x, --cnt);
                Total = Total + n * c;
                return Total;
            });
            //Console.WriteLine(coeffs.Count());
            return Result;
        }
        static void Main(string[] args)
        {
            int i = 0;
            //string s = "2,[3,4,5]";
            string s = Console.ReadLine();
            string[] s1 = s.Split('[');
           // Console.WriteLine(s1[0] + " " + s1[1]);
            int x = int.Parse(s1[0].Split(',')[0]);
            string[] s2 = s1[1].Split(',');
            int[]a =new int [s2.Length];
            for (i = 0; i < a.Length-1; i++)
            {
                a[i] = int.Parse(s2[i]);
            }
            a[i] = int.Parse(s2[i].Split(']')[0]);
            IEnumerable<int> E = a;
            //int x = 2;
            //IEnumerable<int> E = new int[] { 3, 4, 5 };
            Console.WriteLine(Exercise.poly(x, E));
            Console.Read();
        }
    }
}
