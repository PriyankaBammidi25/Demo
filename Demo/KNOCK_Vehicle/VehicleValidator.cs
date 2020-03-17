using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo.KNOCK_Vehicle
{
    class VehicleValidator
    {

        public String ValidateVehicle(string VehicleNo)
        {
            string s ="^[A-Z]{2}[0-9]{1,2}\\s[A-Z]{2}\\s[0-9]{4}$";
            Regex r = new Regex(s);
            if(r.IsMatch(VehicleNo))
            {
                return null;
            }
            else
                return "Given Vehicle no is invalid";
        }
    }
}
