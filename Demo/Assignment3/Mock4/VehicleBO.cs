using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock4
{
    class VehicleBO
    {
        public List<Vehicle> FindVehicle(List<Vehicle> vehicleList, string type)
        {
            List<Vehicle> L = new List<Vehicle>();
            foreach (var v in vehicleList)
            {
                if (v.Type == type)
                    L.Add(v);
            }
            return L;
        }
        public List<Vehicle> FindVehicle(List<Vehicle> vehicleList, DateTime parkedTime)
        {
            List<Vehicle> L = new List<Vehicle>();
            foreach (var v in vehicleList)
            {
                if (v.Ticket.ParkedTime == parkedTime)
                    L.Add(v);
            }
            return L;
        }

    }
}
