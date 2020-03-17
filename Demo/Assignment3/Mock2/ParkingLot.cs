using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock2
{
    class ParkingLot
    {
        string _name;
        List<Vehicle> _vehicleList;
        public ParkingLot()
        {
           // _vehicleList = null;
        }

        public ParkingLot(string name, List<Vehicle> vehicleList=null)
        {
            _name = name;
           _vehicleList = new List<Vehicle>();
            
        }

        public string Name { get => _name; set => _name = value; }
        internal List<Vehicle> VehicleList { get => _vehicleList; set => _vehicleList = value; }
        public void AddVehicleToParkingLot(Vehicle vehicle)
        {
            _vehicleList.Add(vehicle);
        }
        public bool RemoveVehicleFromParkingLot(string registrationNo)
        {
            
            foreach (var item in _vehicleList)
            {
                if (item.RegistrationNo == registrationNo)
                {
                    _vehicleList.Remove(item);
                    return true;
                }
            }
            return false;
        }
        public void DisplayVehicles()
        {
            if(_vehicleList.Count==0)
            {
                Console.WriteLine("No vehicles to show");
            }
            else
            {
               // Console.WriteLine("Vehicles in [parkingLot name]" + _name);
               Console.WriteLine("Vehicles in" + _name);
                Console.Write("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n", "RegistrationNo", "Name", "Type", "Weight", "Ticket No");
                foreach (var item in _vehicleList)
                {
                    
                    Console.WriteLine("{0,-15} {1,-10} {2,-12} {3,-7} {4}\n" , item.RegistrationNo,item.Name,item.Type,string.Format("{0:0.0}",item.Weight),item.Ticket.TicketNo);
                    
                }
                
            }
        }
    }
}
