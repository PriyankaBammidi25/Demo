using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock7
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
            _name = name;
            _company = company;
            _title = title;
            _mobile = mobile;
            _alternateMobile = alternateMobile;
            _email = email;
            _dateCreated = dateCreated;
        }

        public string Name { get => _name; set => _name = value; }
        public string Company { get => _company; set => _company = value; }
        public string Title { get => _title; set => _title = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }
        public string AlternateMobile { get => _alternateMobile; set => _alternateMobile = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime DateCreated { get => _dateCreated; set => _dateCreated = value; }
        public override string ToString()
        {
           // Contact C = new Contact();
            string s = null;
            s= "Name:"+_name;
            s = s + "\nCompany:" + _company;
            s = s + "\nTitle:" + _title;
            s = s + "\nMobile:" + _mobile;
            s = s + "\nAlternate Contact:" + _alternateMobile;
            s=s+ "\nEmail:"+_email;
            s = s + "\nDate Created:" + _dateCreated.ToString("dd-MM-yyyy");
            return s;
        }
        public override bool Equals(object obj)
        {
            Contact C = (Contact)obj;
            if(_name.ToUpper()==C._name.ToUpper()&&_mobile==C._mobile&&_email==C._email)
            {
                return true;
            }
            return false;
        }
    }
}
