using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock8
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Email Validation \n2. Service Provider Identification ");
            Console.WriteLine("Enter your choice");
            int c=int.Parse(Console.ReadLine());
            switch(c)
            {
                case 1:Console.WriteLine("Enter the email to be validated:");
                   string email= Console.ReadLine();
                    if (Program.ValidateEmailId(email))
                    {
                        Console.WriteLine("Email is valid");
                    }
                    else
                        Console.WriteLine("Email is invalid");
                break;
                case 2:Console.WriteLine("Enter the mobile number to identify the service provider: ");
                    string mobile = Console.ReadLine();
                    Console.WriteLine("Mobile number belongs to" + Program.IdentifyServiceProvider(mobile));
                    break;

            }
            Console.Read();
        }
    }
}
