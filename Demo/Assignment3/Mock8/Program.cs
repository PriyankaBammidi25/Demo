using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock8
{
    class Program
    {
        public static bool ValidateEmailId(string email)
        {
            string s = @"(^[A-Za-z][A-Za-z0-9._]*\@[A-Za-z]+\.[A-Za-z]{2,6}$)";
            Regex reg = new Regex(s);
            if (reg.IsMatch(email))
            {
                return true;
            }
            else
                return false;
        }
        public static string IdentifyServiceProvider(string mobile)
        {
            if (mobile.StartsWith("9870"))
                return "Airtel";
            else if (mobile.StartsWith("7012"))
                return "Jio";
            else if (mobile.StartsWith("8180"))
                return "Vodafone";
            else
                return " not identified";


        }
    }
}
