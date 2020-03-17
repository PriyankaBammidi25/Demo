using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class Mainstudent
    {
        static void Main(string[] args)
        {
            IPayable I = new HOD(2,"ram","F","soc",3,6000,500,43,"CSE");
            I.Calculate();
            I.Display();
            IPayable I1 = new Admin(3, "rama", "F", "PAT", 5000);
            I1.Display();
            IPayable I2 = new TeachingStaff(4, "ramu", "M", "C", 6,4000,30);
            I2.Display();
            Console.Read();
        }
        

    }
}
