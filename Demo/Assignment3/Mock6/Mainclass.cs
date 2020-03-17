using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment3.Mock6
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of vehicles ");
            int n = int.Parse(Console.ReadLine());
            List<Vehicle> L = new List<Vehicle>();
            Vehicle V = new Vehicle();
            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                L.Add(Vehicle.CreateVehicle(s1));
            }
            Console.Write("{0,-15} {1}\n", "Type", "No. of Vehicles");
            SortedDictionary<string, int> D = Vehicle.TypeWiseCount(L);
            //foreach (KeyValuePair<string,int> pair in D)
            //{
                
            //    
            //    Console.Write("{0,-15} {1}\n", pair.Key, pair.Value);
            //}
            ICollection<string> I = D.Keys;
            foreach (string key in I)
            {
                Console.Write("{0,-15} {1}\n", key, D[key]);
            }
            Console.Read();

        }
    }
}
