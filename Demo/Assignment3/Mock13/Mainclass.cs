using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2.Mock13
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of contacts:");
            int n=int.Parse(Console.ReadLine());
            List<Contact> L = new List<Contact>();
            for(int i=0;i<n;i++)
            {
                string s1 = Console.ReadLine();
                string[] s2 = s1.Split(',');
                Contact C = new Contact(s2[0], s2[1], s2[2], s2[3], s2[4], s2[5], DateTime.ParseExact(s2[6],"dd-MM-yyyy",null));
                L.Add(C);
            }
            Console.WriteLine("{0} {1,20}", "Domain Name", "Count");
            SortedDictionary<string, int> D = Contact.GetContactCountForDomain(L);
            ICollection<string> I = D.Keys;
            foreach (var key in I)
            {
                Console.WriteLine("{0} {1,20}", key, D[key]);
            }
            Console.Read();
        }
    }
}
