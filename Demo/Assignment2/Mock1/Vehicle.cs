using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3
{
    class Vehicle
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

        public string RegistrationNo { get => _registrationNo; set => _registrationNo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public double Weight { get => _weight; set => _weight = value; }
        internal Ticket Ticket { get => _ticket; set => _ticket = value; }

        public override string ToString()
        {
            string str = null;
            str=  "Registration No:"+_registrationNo;
            str = str+"\nName: " + _name;
            str=str+"\nType: "+_type;
            str = str + "\nWeight: " +string.Format("{0:0.0}",_weight);
            str = str + "\nTicket No:" + _ticket.TicketNo;
            return str;
        }
        public override bool Equals(object obj)
        {
            Vehicle V2 = (Vehicle)obj;
            if (_registrationNo.ToUpper() == V2._registrationNo.ToUpper() && _name == V2._name)
                return true;
            else
                return false;

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
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Vehicle 1 details: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter Vehicle 2 details: ");
            string s2 = Console.ReadLine();
            string[] v1 = s1.Split(',');
            Ticket T = new Ticket(v1[4],DateTime.Parse(v1[5]),double.Parse(v1[6]));
            Vehicle V1 = new Vehicle(v1[0],v1[1],v1[2],double.Parse(v1[3]),T);
            string[] v2 = s2.Split(',');
            Ticket T1 = new Ticket(v2[4], DateTime.Parse(v2[5]), double.Parse(v2[6]));
            Vehicle V2 = new Vehicle(v2[0], v2[1], v2[2], double.Parse(v2[3]), T1);
            Console.WriteLine("Vehicle 1");
            Console.WriteLine();
            Console.WriteLine(V1);
            Console.WriteLine("Vehicle 2");
            Console.WriteLine();
            Console.WriteLine(V2);
            Console.WriteLine();
            if (V1.Equals(V2))
            {
                Console.WriteLine("Vehicle 1 is same as Vehicle 2");
            }
            else
            {
                Console.WriteLine("Vehicle 1 and Vehicle 2 are different ");
            }
            Console.Read();
        }
    }
}
