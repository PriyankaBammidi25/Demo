using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class BankAcc : ITransaction
    {
        int Acctid;
        string AcctName;
        double balance;
        
        public BankAcc(int acctid, string acctName, double balance)
        {
            Acctid = acctid;
            AcctName = acctName;
            this.balance = balance;
        }
        public double Number
        {
            
            get 
            {
                return 3000;
            }
        }
        public void Deposit()
        {
            Console.WriteLine("enter deposit amt");
            double input = double.Parse(Console.ReadLine());
            balance = balance + input;
            //return balance;
            
        }

        public void Withdrawal()
        {
            Console.WriteLine("enter withdral amt");
            double input1 = double.Parse(Console.ReadLine());
            if (balance-input1>Number)
            {
                balance = balance - input1;
                
            }

            else
                Console.WriteLine("insufficient");

         }
        public void Display()
        {
            Console.WriteLine("Account id" + Acctid);
            Console.WriteLine("Accountname" + AcctName);
            Console.WriteLine("balance" + balance);

        }
        public void doTransaction()
        {
            Console.WriteLine("select 1 or 2");
            int n = int.Parse(Console.ReadLine());
            // Console.WriteLine(n);
            if (n == 1)
                Deposit();
            else if (n == 2)
                Withdrawal();
            else
                Console.WriteLine("Invalid");
        }
    }

}
