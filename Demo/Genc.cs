using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    
        //Implement code here
        public class Account
        {
            int id;
            string accountType;
            double balance;
            public int Id { get => id; set => id = value; }
            public string AccountType { get => accountType; set => accountType = value; }
            public double Balance { get => balance; set => balance = value; }

            public Account()
            {

            }
            public Account(int id, string accountType, double balance)
            {
                this.id = id;
                this.accountType = accountType;
                this.balance = balance;
            }
            public bool Withdraw(double amount)
            {
                if (balance < amount)
                {
                    return false;
                }
                else
                {
                    balance = balance - amount;
                    return true;
                }
            }
            public string GetDetails()
            {
                return "Account Id:" + id + "\n" + "Account Type:" + accountType + "\n" + "Balance:" + balance;
            }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Account A = new Account();
                Console.WriteLine("Enter account id");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter account type");
                Console.ReadLine();
                Console.WriteLine("Enter account balance");
                double.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter amount to withdraw");
                double wa = double.Parse(Console.ReadLine());
            
            A.GetDetails();
            A.Withdraw(wa);
                Console.Read();
            }
        }
    
}
