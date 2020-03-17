using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.KNOCK_Vehicle
{
    class VehicleDetails
    {
        string vehicleNo;
        string brand;
        DateTime dateofManufacture;
        DateTime dateofRegistration;
        string vehicleType;
        string vehicleBuyer;
        int cost;
        float registrationCost;
        public string VehicleNo { get => vehicleNo; set => vehicleNo = value; }
        public string Brand { get => brand; set => brand = value; }
        public DateTime DateofManufacture { get => dateofManufacture; set => dateofManufacture = value; }
        public DateTime DateofRegistration { get => dateofRegistration; set => dateofRegistration = value; }
        public string VehicleType { get => vehicleType; set => vehicleType = value; }
        public string VehicleBuyer { get => vehicleBuyer; set => vehicleBuyer = value; }
        public int Cost { get => cost; set => cost = value; }
        public float RegistrationCost { get => registrationCost; set => registrationCost = value; }
    }
}
