using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Demo.Assignment3
{
    class Program
    {
        public static bool ValidateRegistrationNo(string registrationNo)
        {
           
            string s1 = @"([A-Z]{2}\s[0-9]{1,2}\s[A-Z]{0,2}\s[0-9]{1,4})|([A-Z]{2}\s[0-9]{1,2}\s[A-Z]{0,2}[0-9]{1,4})";
            Regex reg = new Regex(s1);
            if (reg.IsMatch(registrationNo))
            {
                return true;
            }
            else
                return false;
        }
    
        static void Main(string[] args)
        {
            Console.Write("Enter the registration no. to be validated: ");
            string s=Console.ReadLine();
            //string[] s = registrationNo
            Program P = new Program();
            if(ValidateRegistrationNo(s))
            {
                Console.WriteLine("Registration No. is valid");
            }
            else
                Console.WriteLine("Registration No. is invalid");
            Console.Read();
        }
    }
}
