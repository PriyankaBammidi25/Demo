using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    abstract class Person
    {
         string Name, Address;
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
        public abstract double Calculate();
        public virtual void Display()
        {
            Console.WriteLine("Name" + Name);
            Console.WriteLine("Address" + Address);
        }
    }
    class Student : Person 
    {
        int prg, year;
            double d,fee;

        public Student(string Name,string Address,int prg, int year, double fee):base(Name,Address)
        {
            this.prg = prg;
            this.year = year;
            this.fee = fee;
        }
        public  override double Calculate()
        {
           
            return d= fee- fee * 10 / 100;
        }
        public override void Display()
        {
            base.Display();
            Calculate();
            Console.WriteLine("d"+d);
        }
    }
    class Staff:Person
    {
        double Finalpay,p;

        public Staff(string Name, string Address, int prg,double p):base(Name,Address)
        {
            this.p=p ;
           
        }
        public override double Calculate()
        {
             Finalpay= p + p * 10 / 100 + p* 40 / 100;
            return Finalpay;
        }
        public override void Display()
        {
            base.Display();
            Calculate();
            Console.WriteLine("Finalpay " + Finalpay);
        }
    }
    class Mainque
    {
        static void Main(string[] args)
        {
            Person P = new Student("Rama","45-6",12,2019,4500);
            P.Display();
            Person P1 = new Staff("ram","45-6",13,98000);
            P1.Display();
            Console.Read();

        }
    }


}
