using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.KNOCKOUT2
{
    class DistanceValidator
    {
        public string ValidateTravelDate(int TravelDistance)
        {
            if (TravelDistance < 0)
                return "Given distance is invalid";
            else
                return null;
        }
    }
}
