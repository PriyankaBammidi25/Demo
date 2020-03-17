using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2.Mock13
{
    class Contact
    {
        string _name;
        string _company;
        string _title;
        string _mobile;
        string _alternateMobile;
        string _email;
        DateTime _dateCreated;

        public Contact(string name, string company, string title, string mobile, string alternateMobile, string email, DateTime dateCreated)
        {
            Name = name;
            Company = company;
            Title = title;
            Mobile = mobile;
            AlternateMobile = alternateMobile;
            Email = email;
            DateCreated = dateCreated;
        }

        public string Name { get => _name; set => _name = value; }
        public string Company { get => _company; set => _company = value; }
        public string Title { get => _title; set => _title = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
        public string AlternateMobile { get => _alternateMobile; set => _alternateMobile = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime DateCreated { get => _dateCreated; set => _dateCreated = value; }

        public static SortedDictionary<string, int> GetContactCountForDomain(List<Contact> list)
        {
            string s = "";
            int d = 0;
            string[] a;
            int A = 0, ib = 0,IN=0,m=0 ;
            foreach (var i in list)
            {
                a = i.Email.Split('@');
                d = a[1].LastIndexOf('.');
                s = a[1].Substring(0, d);
                if (s == "apple")
                    A++;
                else if (s == "ibm")
                    ib++;
                else if (s == "intel")
                    IN++;
                else if(s=="micro")
                    m++;
               
            }
            SortedDictionary<string, int> D = new SortedDictionary<string, int>();
            D.Add("apple", A);
            D.Add("ibm", ib);
            D.Add("intel", IN);
            D.Add("micro", m);
            return D;
        }
    }
}
