using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2
{
    class Que1
    {
        public static int CheckDigit(int MembershipId)
        {
            int sum = 0,n;
            while(MembershipId>0)
            {
                n = MembershipId % 10;
                sum = sum + n;
                MembershipId = MembershipId/10;
            }
            if (sum >= 10)
            {
                sum = (CheckDigit(sum));
            }
            return sum;
            
        }


        static void Main(string[] args)
        {
            int MembershipId = int.Parse(Console.ReadLine());
            // Que1 Q = new Que1();
            Console.WriteLine(CheckDigit(MembershipId));
            Console.Read();

        }

    }
}
