using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Demo
{
    class ReadT
    {
        static void Main(string[] args)
        {
            SqlConnection con1 = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=ADODB;Data Source=DESKTOP-B42VFF8");
            con1.Open();
            SqlCommand cmd = new SqlCommand("insert into Emp values(@Eno,@En,@G,@D,@Dn)", con1);
            cmd.Parameters.AddWithValue("@Eno", int.Parse(Console.ReadLine()));
            cmd.Parameters.AddWithValue("@En", Console.ReadLine());
            cmd.Parameters.AddWithValue("@G", Console.ReadLine());
            cmd.Parameters.AddWithValue("@D", DateTime.Parse(Console.ReadLine()));
            cmd.Parameters.AddWithValue("@Dn", int.Parse(Console.ReadLine()));
            int R = cmd.ExecuteNonQuery();
            Console.WriteLine(R + "inserted");
            con1.Close();
            ReadT T = new ReadT();
            T.Method1(con1);
            Console.Read();
        }
        public void Method1(SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Emp set Ename=@En,Deptno=@Dn where Empno=@Eno");
            cmd.Parameters.AddWithValue("@En", Console.ReadLine());
            cmd.Parameters.AddWithValue("@Dn", int.Parse(Console.ReadLine()));
            cmd.Parameters.AddWithValue("@Eno", int.Parse(Console.ReadLine()));
            int R = cmd.ExecuteNonQuery();
            con.Close();
        }
        }
        
    
}
