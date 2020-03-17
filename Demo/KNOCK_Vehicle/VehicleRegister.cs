using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo.KNOCK_Vehicle
{
    class VehicleRegister
    {
        public SqlConnection SqlCon
        {
            get{ return DBHandler.GetConnection(); }
        }
        public void AddVehicle(VehicleDetails detail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into VehicleRegistration values(@vn,@Brand,@DOM,@DOR,@VT,@VB,@Cost,@RCost)", SqlCon);
                cmd.Parameters.AddWithValue("@vn", detail.VehicleNo);
                cmd.Parameters.AddWithValue("@Brand", detail.Brand);
                cmd.Parameters.AddWithValue("@DOM", detail.DateofManufacture);
                cmd.Parameters.AddWithValue("@DOR", detail.DateofRegistration);
                cmd.Parameters.AddWithValue("@VT", detail.VehicleType);
                cmd.Parameters.AddWithValue("@VB", detail.VehicleBuyer);
                cmd.Parameters.AddWithValue("@Cost", detail.Cost);
                cmd.Parameters.AddWithValue("@RCost", detail.RegistrationCost);
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
        public void CalculateCost(VehicleDetails detail)
        {
            int datediff = (int)DateTime.Now.Subtract(detail.DateofManufacture).TotalDays / 365;
            if (detail.VehicleType == "2 Wheeler" && detail.VehicleBuyer == "New")
                detail.RegistrationCost =  detail.Cost * 12 / 100;
            else if (detail.VehicleType == "Four Wheeler" && detail.VehicleBuyer == "New")
                detail.RegistrationCost =  detail.Cost * 14 / 100;
            else if (detail.VehicleType == "2 Wheeler" && detail.VehicleBuyer == "Old" &&datediff>=5)
                detail.RegistrationCost=  detail.Cost * 8 / 100;
            else if (detail.VehicleType == "2 Wheeler" && detail.VehicleBuyer == "Old" && datediff >= 3 && datediff <=5)
                detail.RegistrationCost =  detail.Cost * 9 / 100;
            else if (detail.VehicleType == "2 Wheeler" && detail.VehicleBuyer == "Old" && datediff <3)
                detail.RegistrationCost =  detail.Cost * 10 / 100;
            else if (detail.VehicleType == "Four Wheeler" && detail.VehicleBuyer == "Old" && datediff >= 5)
                detail.RegistrationCost =  detail.Cost * 9 / 100;
            else if (detail.VehicleType == "Four Wheeler" && detail.VehicleBuyer == "Old" && datediff >= 3 && datediff <= 5)
                detail.RegistrationCost = (int)( detail.Cost * 10.5 / 100);
            else if (detail.VehicleType == "Four Wheeler" && detail.VehicleBuyer == "Old" && datediff < 3)
                detail.RegistrationCost = (int)(detail.Cost * 12.50 / 100);
        }
        public List<VehicleDetails> DisplayDetails(DateTime startDate, DateTime endDate)
        {
            List<VehicleDetails> L = new List<VehicleDetails>();
            SqlCommand cmd = new SqlCommand("select * from VehicleRegistration where DateofRegistration between @s and @e", SqlCon);
            cmd.Parameters.AddWithValue("@s", startDate);
            cmd.Parameters.AddWithValue("@e", endDate);
            SqlDataReader R = cmd.ExecuteReader();
            VehicleDetails VD = new VehicleDetails();
            try
            {
                while (R.Read())
                {
                    VD = new VehicleDetails();
                    VD.VehicleNo = R[0].ToString();
                    VD.Brand = R[1].ToString();
                    VD.DateofManufacture = DateTime.Parse(R[2].ToString());
                    VD.DateofRegistration = DateTime.Parse(R[3].ToString());
                    VD.VehicleType = R[4].ToString();
                    VD.VehicleBuyer = R[5].ToString();
                    VD.Cost = int.Parse(R[6].ToString());
                    VD.RegistrationCost = int.Parse(R[7].ToString());
                    L.Add(VD);
                }
            }
            catch(SqlException E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                SqlCon.Close();
            }
            return L;

        }

    }
}
