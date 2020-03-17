using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
 
              //DO NOT CHANGE the namespace name
    
        public class Program       //DO NOT CHANGE the class name
        {
            public static void Main(string[] args)    //DO NOT CHANGE the 'Main' method signature
            {
                Console.WriteLine("Enter the date of birth (dd-MM-yyyy): ");
                //Implement code here
                string s = Console.ReadLine();
                Program.calculateAge(s);
                Console.WriteLine(s);
            Console.Read();

            }

            public static int calculateAge(string dateOfBirth)
            {
                //Implement code here
                DateTime d = DateTime.ParseExact(dateOfBirth, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int Age = (int)DateTime.Now.Subtract(d).TotalDays / 365;

            return Age;

            }


        }
    

}

