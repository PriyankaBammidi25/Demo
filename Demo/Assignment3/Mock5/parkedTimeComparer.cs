using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock5
{
    class parkedTimeComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.Ticket.ParkedTime > y.Ticket.ParkedTime)
                return 1;
            else if (x.Ticket.ParkedTime < y.Ticket.ParkedTime)
                return -1;
            else
                return 0;
            //return x.Ticket.ParkedTime.CompareTo(y.Ticket.ParkedTime);
            //throw new NotImplementedException();
        }
    }
}
