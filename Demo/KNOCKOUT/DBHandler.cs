using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Demo.KNOCKOUT
{
    class DBHandler
    {
        //SqlConnection SqlCon = null;
        public static SqlConnection GetConnection()
        {

            //return SqlCon;
            string str = ConfigurationManager.ConnectionStrings["SqlCon"].ToString();
            SqlConnection Con = new SqlConnection(str);
            Con.Open();
            return Con;
            //return new SqlConnection(str);
        }
    }
}
