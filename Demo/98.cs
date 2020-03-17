using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
   
        interface IOpenable
        {
     string OpenSesame();
    }
    public class TreasureBox : IOpenable
    {
       public  string OpenSesame()
        {
            return "Congratulations , Here is your lucky win";
        }
    }
}

