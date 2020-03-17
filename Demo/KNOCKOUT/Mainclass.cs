using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demo.KNOCKOUT
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            ElectricityBill E = new ElectricityBill();
            ElectricityBoard EB = new ElectricityBoard();
            BillValidator B = new BillValidator();
            string s = @"(^[E][B][0-9]{5}$)";
            string num, name;

             List<ElectricityBill> L1 = new List<ElectricityBill>();
            Console.WriteLine("Number of bills to be added");
            int n = int.Parse(Console.ReadLine());
            ElectricityBill[] ebill = new ElectricityBill[n];
            for(int i = 0; i < n; i++)
            {
                try
                {
                   ebill[i] = new ElectricityBill();
                    Console.WriteLine("Enter Consumer Number:");
                    num=Console.ReadLine();
                    //Console.WriteLine(num);
                    Regex r = new Regex(s);
                    if(r.IsMatch(num))
                    {
                        ebill[i].ConsumerNumber = num;
                    }
                    else
                        throw new FormatException("Invalid Consumer Number");
                    
                    Console.WriteLine("Enter Consumer Name:");
                    name=Console.ReadLine();
                    ebill[i].ConsumerName = name;
                    
                    Console.WriteLine("Enter Units Consumed:");
                    int s1 = int.Parse(Console.ReadLine());
                    //ebill[i].UnitsConsumed = s1;
                    while (B.ValidateUnitsConsumed(s1)!=null)
                    {
                        Console.WriteLine(B.ValidateUnitsConsumed(s1));
                        Console.WriteLine("Enter Units Consumed:");
                        s1 = int.Parse(Console.ReadLine());
                    }
                    ebill[i].UnitsConsumed = s1;
                    EB.AddBill(ebill[i]);
                    L1.Add(ebill[i]);
                    
                }
                catch (FormatException F)
                {
                    Console.WriteLine(F.Message);
                }
            }
            
            Console.WriteLine("Enter Last 'N' Number of Bills To Generate:");
            int N = int.Parse(Console.ReadLine());
            List<ElectricityBill> L = EB.Generate_N_BillDetails(N);
            //Console.WriteLine(ebill.Length);
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(ebill[i]);
                Console.WriteLine();
            }
            
            Console.WriteLine("Details of N bill");
            for(int i=0;i<N;i++)
            {
                Console.WriteLine("EB Bill for " + L[i].ConsumerName + " is " + L[i].BillAmount);
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
