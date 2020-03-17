using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.KNOCKOUT2
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            TicketBooking TB = new TicketBooking();
            TicketDetail TD = new TicketDetail();
            DistanceValidator DV = new DistanceValidator();
            //TicketBooking[] detail = new TicketBooking[];
            List<TicketDetail> L1 = new List<TicketDetail>();
            while (true)
            {

                TD = new TicketDetail();
                Console.WriteLine("Enter Ticket Details");
                Console.WriteLine("Enter PassengerId");
                string pid = Console.ReadLine();
                TD.PassengerId = pid;
                Console.WriteLine("Enter PassengerName");
                string pname = Console.ReadLine();
                TD.PassengerName = pname;
                Console.WriteLine("Enter TravelDate");
                string TDate = Console.ReadLine();
                TD.TravelDate = TDate;
                Console.WriteLine("Enter distance Traveled");
                int Dis = int.Parse(Console.ReadLine());
                if (DV.ValidateTravelDate(Dis) != null)
                {
                    Console.WriteLine(DV.ValidateTravelDate(Dis));
                    Console.WriteLine("Enter distance Traveled");
                    Dis = int.Parse(Console.ReadLine());
                }
                TD.DistanceTravel = Dis;
                TB.CalculateCost(TD);
                TB.AddTicket(TD);
                L1.Add(TD);
                Console.WriteLine("Book another ticket(y/n)");
                string ch = Console.ReadLine();
                if (ch == "y")
                    continue;
                else
                    break;
            }
                foreach (var i in L1)
                {
                Console.WriteLine();
                    Console.WriteLine(i.PassengerId + "\n" + i.PassengerName + "\n" + i.TravelDate + "\n" + i.DistanceTravel + "\n" + "TicketCost "+i.TicketCost);
                }
             Console.Read();
                

            //
            //
            //
            //string TDate = Console.ReadLine();
            //Console.WriteLine("Book another ticket(y/n)");
            //char ch = (Console.ReadLine());
            //switch(ch)
            //{
            //    case 1:
            //        Console.WriteLine("Enter Ticket Details");
            //        Console.WriteLine("Enter PassengerId");
            //         Console.ReadLine();
            //        Console.WriteLine("Enter PassengerName");
            //         Console.ReadLine();
            //        Console.WriteLine("Enter TravelDate");
            //         Console.ReadLine();
            //        Console.WriteLine("Book another ticket(y/n)");
            //        Console.ReadLine();
            //        break;
            //    case 2: System.Environment.Exit(0);
            //        break;
        }
    }
}
