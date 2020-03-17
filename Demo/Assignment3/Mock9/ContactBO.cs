using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock9
{
    class ContactBO
    {
        public List<Contact> FindContact(List<Contact> contactList, List<string> name)
        {
            List<Contact> C = new List<Contact>();
            foreach(string s in name)
            {
                foreach (var i in contactList)
                {
                    if (s == i.Name)
                    {
                        C.Add(i);
                    }
                }
            }
            return C;
           
        }
        public List<Contact> FindContact(List<Contact> contactList, DateTime dateCreated)
        {
            List<Contact> C1 = new List<Contact>();
            foreach(var i in contactList)
            {
                if(i.DateCreated==dateCreated)
                {
                    C1.Add(i);
                }
            }
            return C1;
                
        }
        public List<Contact> FindContact(List<Contact> contactList, string domain)
        {
            List<Contact> C2 = new List<Contact>();
            string s = "";
            int dotp = 0;
            string[] a;
            
            //int A=a[1].LastIndexOf('@');
           
            foreach(var i in contactList)
            {
                a = i.Email.Split('@');
                dotp = a[1].LastIndexOf('.');
                s = a[1].Substring(0, dotp);
                if (s==domain)
                {
                    C2.Add(i);
                }
            }
            return C2;
        }
    }
}
