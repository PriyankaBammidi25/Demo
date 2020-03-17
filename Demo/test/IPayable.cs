using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    interface IPayable
    {
        double Calculate();
        void Display();
    }
  abstract class Staff:IPayable
  {
        int Staffid;
        string Staffname,Gender;

        public Staff(int staffid, string staffname, string gender)
        {
            Staffid = staffid;
            Staffname = staffname;
            Gender = gender;
        }
        public abstract double Calculate();
        public abstract void Display(); 
        public int Staffid1
        {
            get
            {
                return Staffid;
            }
        }
                
        public string Staffname1
        {
            get
            {
                return Staffname;
            }
        }
                
        public string Gender1
        {
            get
            {
                return Gender;
            }
        }       
  }
    class Admin : Staff 
    {
        string Designation;
        double basic;

        public Admin(int Staffid,string Staffname,String Gender,string designation, double basic):base(Staffid,Staffname,Gender)
        {
            Designation = designation;
            this.basic = basic;
        }

        public override double Calculate()
        {
            double HRA = 10 / 100 * basic;
            double DA = 40 / 100 * basic;
            double Gross = HRA + DA + basic;
            return Gross;
        }

        public override void Display()
        {

            Console.WriteLine("Staffid " + Staffid1);
            Console.WriteLine("StaffName " + Staffname1);
            Console.WriteLine("Gender " + Gender1);
            Console.WriteLine("Designation" + Designation);
           // double FinalPay = Calculate();
            Console.WriteLine("Basic " + basic);
            Console.WriteLine("Finalpay " + Calculate());

        }

        
    }
    class TeachingStaff : Staff
    {
        string Sub;
        int Exp;
        double basic,TeachingALL;

        public TeachingStaff(int Staffid,string Staffname,string Gender,string sub, int exp, double basic, double teachingALL):base(Staffid,Staffname,Gender)
        {
            Sub = sub;
            Exp = exp;
            this.basic = basic;
            TeachingALL = teachingALL;
        }

        public override double Calculate()
        {
            double HRA = 15 / 100 * basic; 
            double DA=60 / 100 * basic;
            //TeachingALL= double.Parse(Console.ReadLine());
            double Gross = HRA + DA + basic + TeachingALL;
            return Gross;
        }

        public override void Display()
        {

            Console.WriteLine("Staffid" + Staffid1);
            Console.WriteLine("Staffname " + Staffname1);
            Console.WriteLine("gender " + Gender1);
            Console.WriteLine("Sub " + Sub);
            Console.WriteLine("Exp " + Exp);
            Console.WriteLine("Teachingallowance " + TeachingALL);
            Console.WriteLine("Gross " + Calculate());
        }

    }
    class HOD:TeachingStaff
    {
        int Deptid;
        string Deptname;

        public HOD(int Staffid,string Staffname,string Gender,string Sub,int Exp,double basic,double TeachingALL,int deptid, string deptname):base(Staffid,Staffname,Gender,Sub,Exp,basic,TeachingALL)
        {
            Deptid = deptid;
            Deptname = deptname;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Deptid " + Deptid);
            Console.WriteLine("Deptname " + Deptname);

        }

    }
}
