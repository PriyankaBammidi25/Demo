using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo.KNOCKOUT2
{ 
    class TicketBooking
    {
        //public SqlConnection SqlCon;
        public SqlConnection SqlCon
        {
            get
            {
                return DBHandler.GetConnection();
            }
        }
        public void AddTicket(TicketDetail detail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TicketBooking values(@pid,@pname,@TDate,@TDis,@TCost)", SqlCon);
                cmd.Parameters.AddWithValue("@pid", detail.PassengerId);
                cmd.Parameters.AddWithValue("@pname", detail.PassengerName);
                cmd.Parameters.AddWithValue("@TDate", detail.TravelDate);
                cmd.Parameters.AddWithValue("@TDis", detail.DistanceTravel);
                cmd.Parameters.AddWithValue("@TCost", detail.TicketCost);
                
                cmd.ExecuteNonQuery();
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                SqlCon.Close();
            }

        }
        public void CalculateCost(TicketDetail detail)
        {
            if (detail.DistanceTravel <= 100)
                detail.TicketCost = detail.DistanceTravel * 1;
            else if (detail.DistanceTravel > 100 && detail.DistanceTravel <= 300)
                detail.TicketCost = detail.DistanceTravel * 1.5;
            else if (detail.DistanceTravel > 300 && detail.DistanceTravel <= 500)
                detail.TicketCost = detail.DistanceTravel * 2.5;
            else if (detail.DistanceTravel > 500)
                detail.TicketCost = detail.DistanceTravel * 4.5;
        }
    }
}
