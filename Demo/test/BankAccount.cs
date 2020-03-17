using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    abstract class BankAccount
    {
        string CustName;
        protected int balance;
        public BankAccount(string custName, int balance)
        {
            CustName = custName;
            this.balance = balance;
        }
        public abstract string Withdraw(int amt);
        public void Deposit(int amt)
        {
            balance = balance+amt;
            Console.WriteLine(balance);
        }
        public abstract void AddInterests();
        public override string ToString()
        {
            return "CustName " + CustName +"balance "+ balance;
        }
    }
    class SavingAccount:BankAccount
    {
        int interestrate;
        public SavingAccount(string custName, int balance,int interestrate):base(custName,balance)
        {
            this.interestrate = interestrate;
        }
        public override string Withdraw(int amt)
        {
            
            if (amt > balance)
                return "Insufficientamount";
            else 
                balance = balance - amt;
            return "balance" + balance;
        }
        public override void AddInterests()
        {
            balance = balance + balance * interestrate / 100;
        }
    }
    class Currentaccount:BankAccount
    {
        int interestrate;

        public Currentaccount(string custName, int balance, int interestrate):base(custName,balance)
        {
            this.interestrate = interestrate;
        }
        public override string Withdraw(int amt)
        {
            balance = balance - amt;
            if (balance < 5000)
                return "insufficient";
            else
                return "balance"+ balance;
        }
        public override void AddInterests()
        {
            balance = balance + balance * interestrate / 100;
        }
    }
    class Mainclass
    {
        static void Main(string[] args)
        {
            BankAccount B = new SavingAccount("ram ", 20000, 1) ;
            Console.WriteLine(B);
            B.Deposit(4000);
            Console.WriteLine(B);
            Console.WriteLine(B.Withdraw(7000));
            Console.WriteLine(B);
            B.AddInterests();
            Console.WriteLine(B);
            BankAccount B1 = new Currentaccount("rahim ", 50000, 2);
            Console.WriteLine(B1);
            B1.Deposit(5000);
            Console.WriteLine(B1);
            Console.WriteLine(B1.Withdraw(6000));
            Console.WriteLine(B1);
            B1.AddInterests();
            Console.WriteLine(B1);


            Console.Read();
        }
    }
}
