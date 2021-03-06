﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock10
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
        public Contact()
        {

        }
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
        public static Contact CreateContact(string detail)
        {
            string[] s = detail.Split(',');
            Contact C = new Contact(s[0], s[1], s[2], s[3], s[4], s[5], DateTime.ParseExact(s[6],"dd-MM-yyyy",null));
            return C;
        }
        public override string ToString()
        {
            return string.Format("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", Name, Company, Title, Mobile, AlternateMobile, Email, DateCreated.ToString("dd-MM-yyyy")); 
        }
    }
}
