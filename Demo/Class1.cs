using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo
{
    class Class1
    {
        static void Main(string[] args)
        {
            //string con = @"Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-B42VFF8";
            SqlConnection con1 = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-B42VFF8");
            con1.Open();
            SqlCommand cmd = new SqlCommand("select * from Empdata", con1);
            SqlDataReader R = cmd.ExecuteReader();
            while (R.Read())
            {
                Console.WriteLine(R[0].ToString() + " " + R[1].ToString());
            }
            Console.Read();
        }
    }
}
