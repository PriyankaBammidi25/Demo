using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.KNOCK_Vehicle
{
    class Mainclass
    {
        static void Main(string[] args)
        {
            //VehicleDetails VD = new VehicleDetails();
            VehicleValidator VV = new VehicleValidator();
            VehicleRegister VR = new VehicleRegister();
            VehicleDetails detail = new VehicleDetails();

            Console.WriteLine("1.Add Details\n2.Display Details");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                Console.WriteLine("Enter Vehicle Details");
                Console.WriteLine("Enter VehicleNo:");
                string VN = (Console.ReadLine());
                if (VV.ValidateVehicle(VN) != null)
                {
                    Console.WriteLine(VV.ValidateVehicle(VN));
                }
                else
                {
                    detail.VehicleNo = VN;
                    Console.WriteLine("Enter Brand");
                    string B = Console.ReadLine();
                    detail.Brand = B;
                    Console.WriteLine("Enter Date of Manufacture");
                    DateTime dom = DateTime.ParseExact(Console.ReadLine(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                    int datediff = (int)DateTime.Now.Subtract(dom).TotalDays / 365;
                    Console.WriteLine(datediff);
                    if (datediff > 15)
                    {
                        Console.WriteLine("Given Vehicle cannot be registered as it is more than  15  year.");
                    }
                    else
                    {
                        detail.DateofManufacture = dom;
                        Console.WriteLine("Enter Date of Registration:");
                        DateTime dor = DateTime.ParseExact(Console.ReadLine(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                        detail.DateofRegistration = dor;
                        Console.WriteLine("Enter VehicleType:");
                        string type = Console.ReadLine();
                        detail.VehicleType = type;
                        Console.WriteLine("Enter Vehicle Buyer:");
                        string buyer = Console.ReadLine();
                        detail.VehicleBuyer = buyer;
                        Console.WriteLine("Cost");
                        int Cost = int.Parse(Console.ReadLine());
                        detail.Cost = Cost;
                        VR.CalculateCost(detail);
                        Console.WriteLine("Vehicle Details are as follows");
                        Console.WriteLine("Enter VehicleNo:\t\t\t\t"+detail.VehicleNo);
                        Console.WriteLine("Enter Brand:\t\t\t\t\t" + detail.Brand);
                        Console.WriteLine("Enter Date of Manufacture:\t\t\t" + detail.DateofManufacture.ToString("dd-MMM-yyyy"));
                        Console.WriteLine("Enter Date of Registration:\t\t\t" + detail.DateofRegistration.ToString("dd-MMM-yyyy"));
                        Console.WriteLine("Enter VehicleType:\t\t\t\t" + detail.VehicleType);
                        Console.WriteLine("Enter Vehicle Buyer:\t\t\t\t" + detail.VehicleBuyer);
                        Console.WriteLine("Vehicle Cost:\t\t\t\t\t" + detail.Cost);
                        Console.WriteLine("Registration Cost:\t\t\t\t" + detail.RegistrationCost);
                        Console.WriteLine("Vehicle life  \t\t\t\t\t" + datediff);
                        Console.WriteLine("Confirm the details Y/N?");
                        string confirm = Console.ReadLine();
                        if(confirm=="Y")
                        {
                            VR.AddVehicle(detail);
                        }
                        else if(confirm=="N")
                        {
                            System.Environment.Exit(0);

                        }


                    }

                }
            }
            else if(ch==2)
            {
                Console.WriteLine("Enter Start Date : ");
                DateTime Start = DateTime.ParseExact(Console.ReadLine(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("Enter End Date: ");
                DateTime End = DateTime.ParseExact(Console.ReadLine(), "dd-MMM-yyyy", CultureInfo.InvariantCulture);
                List<VehicleDetails> display = VR.DisplayDetails(Start, End);
                Console.WriteLine("Vehicle No   	Brand	Date of Manufacture 	Date of Registration 	Vehicle Type  	Vehicle Buyer  	Cost   	Registration Cost");
                foreach(var i in display)
                {
                    Console.WriteLine(i.VehicleNo + "\t" + i.Brand + "\t" + i.DateofManufacture + "\t" + i.DateofRegistration + "\t" + i.VehicleType + "\t" + i.VehicleBuyer + "\t\t" + i.Cost + "\t" + i.RegistrationCost);
                }
            }
            Console.Read();

        }
    }
}
