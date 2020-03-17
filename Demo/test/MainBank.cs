using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class MainBank
    {
        static void Main(string[] args)
        {
            BankAcc B = new BankAcc(25,"Ram",5000);
            B.doTransaction();
            B.Display();
           
             Console.Read();
        }
    }
}
