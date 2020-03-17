using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock5
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the vehicles:");
            int n=int.Parse(Console.ReadLine());
            Vehicle B = new Vehicle();
            //parkedTimeComparer P = new parkedTimeComparer();
            List<Vehicle> L = new List<Vehicle>();
            for (int i=0;i<n;i++)
            {
                string s1=Console.ReadLine();
                L.Add(Vehicle.CreateVehicle(s1));
            }
            Console.WriteLine("Enter a type to sort: ");
            Console.WriteLine("1.Sort by weight\n 2.Sort by parked time ");
            int ch=int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    //string s = Console.ReadLine();
                    //List<Vehicle> L1 = new List<Vehicle>();
                    L.Sort();
                    Console.WriteLine("{0,-15}{1,-10}{2,-12}{3,-7}{4}", "RegistrationNo", "Name", "Type", "Weight", "Ticket No");
                    foreach(var i in L)
                    {
                        Console.WriteLine("{0,-15}{1,-10}{2,-12}{3,-7}{4}", i.RegistrationNo, i.Name, i.Type, string.Format("{0:0.0}",i.Weight), i.Ticket.TicketNo);
                    }  
                    break;
                case 2:
                    //string s1 = Console.ReadLine();
                    //List<Vehicle> L2 = new List<Vehicle>();
                    parkedTimeComparer P = new parkedTimeComparer();
                    L.Sort(P);
                    Console.WriteLine("{0,-15}{1,-10}{2,-12}{3,-7}{4}", "RegistrationNo", "Name", "Type", "Weight", "Ticket No");
                    foreach (var i in L)
                    {
                        Console.WriteLine("{0,-15}{1,-10}{2,-12}{3,-7}{4}", i.RegistrationNo, i.Name, i.Type, string.Format("{0:0.0}",i.Weight), i.Ticket.TicketNo);
                    }
                    break;
                default:
                    System.Environment.Exit(0);
                    break;
            }
            Console.Read();
            
        }
    }
}
