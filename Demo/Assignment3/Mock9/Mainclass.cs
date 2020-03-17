using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock9
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of contact details: ");
            int n=int.Parse(Console.ReadLine());
            List<Contact> L = new List<Contact>();
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] s1 = s.Split(',');
                Contact C = new Contact(s1[0], s1[1], s1[2], s1[3], s1[4], s1[5], DateTime.ParseExact(s1[6],"dd-MM-yyyy",null));
                L.Add(C);
            }
            Console.WriteLine("Enter a search type:");
            Console.WriteLine("1.Name\n 2.Date created\n3.Email domain ");
            int ch = int.Parse(Console.ReadLine());
            ContactBO B = new ContactBO();
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Enter the names:");
                    string name1=Console.ReadLine();
                    List<string> S = new List<string>();
                    string[] s=name1.Split(',');
                    foreach(var i in s)
                    {
                        S.Add(i);
                    }
                    List<Contact> C1 = B.FindContact(L, S);
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    foreach(var i in C1)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", i.Name, i.Company, i.Title, i.Mobile, i.AlternateMobile, i.Email, i.DateCreated);
                    }

                    break;
                case 2:  Console.WriteLine("Enter the date to search contacts that were created on that date ");
                    DateTime D = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    List<Contact> C2 = B.FindContact(L, D);
                    foreach (var i in C2)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", i.Name, i.Company, i.Title, i.Mobile, i.AlternateMobile, i.Email, i.DateCreated.ToString("dd-MM-yyyy"));
                    }

                    break;
                case 3:Console.WriteLine("Enter the Email domain to search contacts that have same email domain ");
                    string Email = Console.ReadLine();
                    List<Contact> C3 = B.FindContact(L, Email);
                    Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                    foreach (var i in C3)
                    {
                        Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", i.Name, i.Company, i.Title, i.Mobile, i.AlternateMobile, i.Email, i.DateCreated.ToString("dd-MM-yyyy"));
                    }
                    break;
                default: Console.WriteLine("Invalid choice");
                    //System.Environment.Exit(0);
                    break;
            }
            Console.Read();
            
        }
    }
}
