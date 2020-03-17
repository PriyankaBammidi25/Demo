using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment
{
    class Concat2
    {
        
    public static string[] UniqueNames(string[] names1, string[] names2)
        {
            //throw new NotImplementedException();
            int i;
            List<string> L = new List<string>();
            for (i = 0; i < names1.Length; i++)
                L.Add(names1[i]);
            for (i = 0; i < names2.Length; i++)
                L.Add(names2[i]);
            var n = (from n1 in L select n1).Distinct();
            return n.ToArray();
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", Concat2.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
            Console.Read();
        }
    }
}
