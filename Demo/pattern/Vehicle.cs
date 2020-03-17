using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.pattern
{
    class Vehicle
    {
        string _registrationNo;
        string _name;
        string _type;
        string _weight;
        Ticket _ticket;

        public Vehicle(string registrationNo, string name, string type, string weight, Ticket ticket)
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
        public string Weight { get => _weight; set => _weight = value; }
        internal Ticket Ticket { get => _ticket; set => _ticket = value; }
        public override string ToString()
        {
            return "Registration No: "+_registrationNo+ "\nName:"+_name+"\ntype:"+_type+"\nweight"+_weight+"\nticket"+_ticket;
        }
    }
    class Ticket
    {
        string _ticketNo;
        DateTime _parkedTime;
        double _cost;

        public Ticket(string ticketNo, DateTime parkedTime, double cost)
        {
            _ticketNo = ticketNo;
            _parkedTime = parkedTime;
            _cost = cost;
        }

        public string TicketNo { get => _ticketNo; set => _ticketNo = value; }
        public DateTime ParkedTime { get => _parkedTime; set => _parkedTime = value; }
        public double Cost { get => _cost; set => _cost = value; }
    }
}
