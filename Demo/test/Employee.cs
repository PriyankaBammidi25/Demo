using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class Employee
    {
        int sal, noh, Finalsal;
       
        public void getInfo(int sal, int noh)
        {
            this.sal = sal;
            this.noh = noh;
            //Console.WriteLine(sal);
            //Console.WriteLine(noh);
        }
        public void AddSal()
        {
            if (sal < 500)
                sal = sal + 1000;
            
        }
        public void AddWork()
        {
            if (noh > 6)
                Finalsal = sal + 500;
            
            //Console.WriteLine(sal);
        }
        public override string ToString()
        {
            return " sal " + sal + " noh " + noh + " Finalsal "+Finalsal;

        }
        static void Main(string[] args)
        {
            Employee E = new Employee();
            E.getInfo(600, 7);
            E.AddSal();
            E.AddWork();
            Console.WriteLine(E);
            Console.Read();
        }

    }

        

    
}
