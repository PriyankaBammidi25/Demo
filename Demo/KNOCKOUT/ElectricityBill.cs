using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo.KNOCKOUT
{
    class ElectricityBill
    {
        String consumerNumber;
        String consumerName;
        int unitsConsumed;
        double billAmount;

        public string ConsumerNumber {
            set
            {
                consumerNumber = value;
                
            }
            get => consumerNumber;  }
        public string ConsumerName { get => consumerName; set => consumerName = value; }
        public int UnitsConsumed { get => unitsConsumed; set => unitsConsumed = value; }
        public double BillAmount { get => billAmount; set => billAmount = value; }
        public override string ToString()
        {
            return consumerNumber+"\n"+consumerName+"\n"+unitsConsumed+"\n"+billAmount;
        }
    }
}
