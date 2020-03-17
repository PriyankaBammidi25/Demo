using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock5
{
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
