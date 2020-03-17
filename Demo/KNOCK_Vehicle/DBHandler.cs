using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Demo.KNOCK_Vehicle
{
    class DBHandler
    {
        public static SqlConnection GetConnection()
        {
            string str = ConfigurationManager.ConnectionStrings["SqlCon"].ToString();
            SqlConnection Con = new SqlConnection(str);
            Con.Open();
            return Con;
        }
        
    }
}
