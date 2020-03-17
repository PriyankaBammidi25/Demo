using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock2
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Vehicle V2 = new Vehicle();
            Console.WriteLine("Enter the name of the Parking Lot: ");
            string name=Console.ReadLine();
            List<Vehicle> L = new List<Vehicle>();
            ParkingLot P = new ParkingLot(name,L);
            //ParkingLot P1 = new ParkingLot(name, new List<Vehicle>());
            //List<Vehicle> _vehicleList = new List<Vehicle>();

            int Ch;
                     
            while (true)
            {
                Console.WriteLine("1.Add Vehicle\n2.Delete Vehicle\n3.Display Vehicles\n4.Exit\n  ");
                Console.Write("Enter your choice: ");
               Ch = int.Parse(Console.ReadLine());

                if (Ch == 1)
                {
                    Vehicle V = Vehicle.CreateVehicle(Console.ReadLine());
                    //Vehicle.CreateVehicle("1");
                    P.AddVehicleToParkingLot(V);
                    Console.WriteLine();
                    Console.WriteLine("Vehicle successfully added ");
                   
                }
                else if (Ch == 2)
                {
                    Console.WriteLine("Enter registrationno to be deleted");
                    string RegistrationNo = Console.ReadLine();
                    if (P.RemoveVehicleFromParkingLot(RegistrationNo))
                    {
                        Console.WriteLine("Vehicle successfully deleted");
                    }
                    else
                        Console.WriteLine("Vehicle not found in parkinglot ");
                }
               else if(Ch==3)
                {
                    P.DisplayVehicles();
                }
                else if(Ch==4)
                {
                    System.Environment.Exit(0);
                }
            }

            //Console.Read();
            
        }
    }
}
