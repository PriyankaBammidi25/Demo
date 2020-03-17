using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock7
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contact 1 detail: ");
           string s1= Console.ReadLine();
            string[] s2 = s1.Split(',');
            Console.WriteLine("Enter contact 2 detail:");
            string s3 = Console.ReadLine();
            string[] s4 = s3.Split(',');
            //Console.WriteLine();
           // Console.WriteLine();
            Contact C1 = new Contact(s2[0], s2[1], s2[2], s2[3], s2[4], s2[5], DateTime.ParseExact(s2[6],"dd-MM-yyyy",CultureInfo.InvariantCulture));
            Contact C2= new Contact(s4[0], s4[1], s4[2], s4[3], s4[4], s4[5], DateTime.ParseExact(s4[6],"dd-MM-yyyy",CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Contact 1: ");
            Console.WriteLine(C1);
            Console.WriteLine();
            Console.WriteLine("Contact 2: ");
            Console.WriteLine(C2);
            Console.WriteLine();
            if(C1.Equals(C2))
            {
                Console.WriteLine("Contact 1 is same as Contact 2");
            }
            else
                Console.WriteLine("Contact 1 and Contact 2 are different");
            Console.Read();
        }
    }
}
