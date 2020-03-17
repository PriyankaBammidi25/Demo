using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock2
{
    class Vehicle
    {
        string _registrationNo;
        string _name;
        string _type;
        Double _weight;
        Ticket _ticket;
        public Vehicle()
        {
            
        }
        public Vehicle(string registrationNo, string name, string type, double weight, Ticket ticket)
        {
            _registrationNo = registrationNo;
            _name = name;
            _type = type;
            _weight = weight;
            _ticket = ticket;
        }

        public string RegistrationNo { get => _registrationNo; set => _registrationNo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public double Weight { get => _weight; set => _weight = value; }
        internal Ticket Ticket { get => _ticket; set => _ticket = value; }
        public static Vehicle CreateVehicle(string details)
        {
            //string s1 = Console.ReadLine();
            string[] v1 = details.Split(',');
            Ticket T = new Ticket(v1[4],DateTime.ParseExact(v1[5], "dd-MM-yyyy HH:mm:ss", null),double.Parse(v1[6]));
            Vehicle V = new Vehicle(v1[0],v1[1],v1[2],double.Parse(v1[3]),T);
            
            return V;

        }
    }
    
}
