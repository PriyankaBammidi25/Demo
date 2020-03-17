using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2.Mock12
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the contacts: ");
            int n = int.Parse(Console.ReadLine());
            List<Contact> L = new List<Contact>();
            for(int i=0;i<n;i++)
            {
                string s = Console.ReadLine();
                L.Add(Contact.CreateContact(s));
            }
            Console.WriteLine("Enter a type to sort: ");
            Console.WriteLine("1. Sort by name\n2. Sort by email domain\n3.Sort by date created ");
            int c=int.Parse(Console.ReadLine());
            switch(c)
            {
                case 1:NameComparer NC = new NameComparer();
                    L.Sort(NC);
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    foreach(var i in L)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", i.Name, i.Company, i.Title, i.Mobile, i.AlternateMobile, i.Email, i.DateCreated.ToString("dd-MM-yyyy"));
                    }
                    break;
                case 2: DomainComparer DC = new DomainComparer();
                    L.Sort(DC);
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    foreach (var i in L)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", i.Name, i.Company, i.Title, i.Mobile, i.AlternateMobile, i.Email, i.DateCreated.ToString("dd-MM-yyyy"));
                    }
                    break;
                case 3:DateComparer DaC = new DateComparer();
                    L.Sort(DaC);
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    foreach (var i in L)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", i.Name, i.Company, i.Title, i.Mobile, i.AlternateMobile, i.Email, i.DateCreated.ToString("dd-MM-yyyy"));
                    }
                    break;
                default: 
                    break;
            }
            Console.Read();
        }
    }
}
