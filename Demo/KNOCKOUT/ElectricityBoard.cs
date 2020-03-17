using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.KNOCKOUT
{
    class ElectricityBoard
    {
        //SqlConnection SqlCon = null;
        ///public SqlConnection SqlCon;
        //SqlDataAdapter Adp = null;
        //SqlCommand CMD = null;
        //public ElectricityBoard()
        //{
        //    DBHandler DB = new DBHandler();
        //    DB.GetConnection();
        //}
        public SqlConnection SqlCon
        {
            get 
            {
                return DBHandler.GetConnection(); 
            }
        }

        public void AddBill(ElectricityBill ebill)
        {

            try
            {
                SqlCommand CMD = new SqlCommand("insert into ElectricityBillDB values(@CNum,@CName,@UnitsC,@BA)", SqlCon);
                //SqlCon.Open();
                CMD.Parameters.AddWithValue("@CNum", ebill.ConsumerNumber);
                CMD.Parameters.AddWithValue("@CName", ebill.ConsumerName);
                CMD.Parameters.AddWithValue("@UnitsC", ebill.UnitsConsumed);
                CalculateBill(ebill);
               // Console.WriteLine(ebill.BillAmount);
                CMD.Parameters.AddWithValue("@BA", ebill.BillAmount);
                CMD.ExecuteNonQuery();
            }
            catch(SqlException E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                SqlCon.Close();
            }

            //Adp = new SqlDataAdapter("select * from ElectricityBillDB", SqlCon);
            //DataSet Ds = new DataSet();
            //Adp.Fill(Ds, "E");
            //DataRow R = Ds.Tables["E"].NewRow();
            //R[0] = ebill.ConsumerName;
            //R[1] = ebill.ConsumerNumber;
            //R[2] = ebill.UnitsConsumed;
            //R[3] = ebill.BillAmount;
            //SqlCommandBuilder CMD = new SqlCommandBuilder(Adp);
           
            //CMD.GetInsertCommand();
            //Adp.Update(Ds,"E");

        }
        public void CalculateBill(ElectricityBill ebill)
        {
            if (ebill.UnitsConsumed <= 100)
                ebill.BillAmount = 0;
            else if (ebill.UnitsConsumed <= 300)
                ebill.BillAmount = 100*0+(ebill.UnitsConsumed-100) * 1.5;
            else if (ebill.BillAmount <= 600)
                ebill.BillAmount = 100 * 0 + 200 * 1.5 + (ebill.UnitsConsumed-300) * 3.5;
            else if (ebill.BillAmount <= 1000)
                ebill.BillAmount = 100 * 0 + 200 * 1.5 + 300 * 3.5 +(ebill.UnitsConsumed-600) * 5.5;
            else
                ebill.BillAmount = 100 * 0 + 200 * 0 + 300 * 3.5 + 400 * 5.5 + (ebill.UnitsConsumed - 1000) * 7.5;
        }
       public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            List<ElectricityBill> list = new List<ElectricityBill>();
            try 
            {
                SqlCommand CMD = new SqlCommand("select top " + num + " * from ElectricityBillDB order by consumer_number desc",SqlCon);
                //SqlCon.Open();
                SqlDataReader R=CMD.ExecuteReader();
                ElectricityBill E = null;
                
                while (R.Read())
                {
                    E = new ElectricityBill();
                    E.ConsumerNumber = R[0].ToString();
                    E.ConsumerName = R[1].ToString();
                    E.UnitsConsumed = int.Parse(R[2].ToString());
                    E.BillAmount = float.Parse(R[3].ToString());
                    list.Add(E);
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
            return list;
       }
    }
}
