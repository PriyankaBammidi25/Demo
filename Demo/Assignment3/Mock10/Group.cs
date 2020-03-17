using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock10
{
    class Group
    {
        string _name;
        List<Contact> _contactList;
        public Group()
        {

        }

        public Group(string name, List<Contact> contactList)
        {
            _name = name;
            _contactList = contactList;
        }

        public string Name { get => _name; set => _name = value; }
        internal List<Contact> ContactList { get => _contactList; set => _contactList = value; }
        public void AddContactToGroup(Contact contact)
        {
            _contactList.Add(contact);
        }
        public bool RemoveContactFromGroup(string name)
        {
            foreach (var i in _contactList)
            {
                if (i.Name == name)
                {
                    _contactList.Remove(i);
                    return true;
                }
                   
            }
            return false;
        }
        public void DisplayContacts()
        {
            if (_contactList.Count == 0)
            {
                Console.WriteLine("No contact to show");
            }

            else
            {
                Console.WriteLine("Contacts in " + _name);
                Console.WriteLine("{0} {1,20} {2,20} {3,20} {4,20} {5,20} {6,20}", "Name", "Company", "Title", "Mobile", "Alternate Mobile", "Email", "Date Created");
                foreach (var i in _contactList)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
