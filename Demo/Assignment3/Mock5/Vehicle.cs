using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock5
{
    class Vehicle:IComparable
    {
        string _registrationNo;
        string _name;
        string _type;
        double _weight;
        Ticket _ticket;

        public Vehicle(string registrationNo, string name, string type, double weight, Ticket ticket)
        {
            _registrationNo = registrationNo;
            _name = name;
            _type = type;
            _weight = weight;
            _ticket = ticket;
        }
        public Vehicle()
        {

        }

        public string RegistrationNo { get => _registrationNo; set => _registrationNo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public Ticket Ticket { get => _ticket; set => _ticket = value; }

        public static Vehicle CreateVehicle(string detail)
        {
            string[] s = detail.Split(',');
            Ticket T = new Ticket(s[4], DateTime.ParseExact(s[5], "dd-MM-yyyy HH:mm:ss", null), double.Parse(s[6]));
            Vehicle V = new Vehicle(s[0], s[1], s[2], double.Parse(s[3]), T);
            return V;
        }
        public int CompareTo(object obj)
        {
            Vehicle V = (Vehicle)obj;
            if (Weight >= V.Weight)
                return 1;
            else
                return -1;
            //return Weight.CompareTo(_weight);
        }
    }
    
}
