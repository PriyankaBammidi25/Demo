using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock6
{
    class Vehicle
    {
        string _registrationNo;
        string _name;
        string _type;
        Double _weight;
       
        public Vehicle()
        {

        }
        public Vehicle(string registrationNo, string name, string type, double weight)
        {
            _registrationNo = registrationNo;
            _name = name;
            _type = type;
            _weight = weight;
            
        }

        public string RegistrationNo { get => _registrationNo; set => _registrationNo = value; }
        public string Name { get => _name; set => _name = value; }
        public string Type { get => _type; set => _type = value; }
        public double Weight { get => _weight; set => _weight = value; }
       
        public static Vehicle CreateVehicle(string detail)
        {
            //string s1 = Console.ReadLine();
            string[] v1 = detail.Split(',');
            
            Vehicle V = new Vehicle(v1[0], v1[1],v1[2],double.Parse(v1[3]));

            return V;

        }
        //public static SortedDictionary<string, int> TypeWiseCount(List<Vehicle> vehicleList)
        //{

        //     List<Vehicle> L = new List<Vehicle>();
        //    SortedDictionary<string, int> D = new SortedDictionary<string, int>();
        //    foreach (var item in vehicleList)
        //    {
        //         D= Vehicle.TypeWiseCount(L);
        //    }
        //    //Vehicle.TypeWiseCount(L);
        //    return D;

        //}
        public static SortedDictionary<string, int> TypeWiseCount(List<Vehicle> vehicleList)
        {
            int tw = 0, fw = 0;
            foreach(Vehicle V  in vehicleList)
            {
                if (V.Type == "TwoWheeler")
                {
                    tw++;
                }
                else
                    fw++;
            }
            SortedDictionary<string, int> D = new SortedDictionary<string, int>();
            D.Add("TwoWheeler", tw);
            D.Add("FourWheeler", fw);
            return D;
        }
    }
}
