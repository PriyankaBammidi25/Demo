using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the group name: ");
            string name=Console.ReadLine();
            Group G = new Group(name, new List<Contact>());
            
           // Group G = new Group();
            while(true)
            {
                Console.WriteLine("1.Add Contact\n2.Delete Contact \n3.Display contacts \n4.Exit ");
                Console.WriteLine("ENter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1: Console.WriteLine("Enter the number of contacts: ");
                        int n = int.Parse(Console.ReadLine());
                        
                        for(int i=0;i<n;i++)
                        {
                            Contact C = Contact.CreateContact(Console.ReadLine());
                            //Console.ReadLine();
                            G.AddContactToGroup(C);
                         
                        }
                        break;
                    case 2:Console.WriteLine("Enter the name of the contact to be deleted: ");
                        string delete=Console.ReadLine();
                        if (G.RemoveContactFromGroup(delete))
                        {
                            Console.WriteLine("Contact Successfully deleted");
                        }
                        else
                            Console.WriteLine("Contact Not found");
                        break;
                    case 3:
                        G.DisplayContacts();
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;

                }
            }
            Console.Read();
            

        }
    }
}
