using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    using System;

    public class Program      //DO NOT change the class name
    {
        //implement code here
        public static void Main(string[] args)
        {
            Product P = new Product();
            Console.WriteLine("Enter product id");
            P.ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name");
            P.ProductName = (Console.ReadLine());
            Console.WriteLine("Enter product price");
            P.Price = double.Parse(Console.ReadLine());
            P.Display();
            Console.Read();
        }
    }
    public class Product
    {
        private int productId;
       

        private string productName;

        private double price;

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double Price
        {
            get
            { return price; }
            set
            {
                if(value>=0)
                {
                    price = value;
                }
                else if(value<0)
                {
                    price = 0;
                }
            }
            
        }
        public void Display()
        {
            Console.WriteLine("Product ID:" + productId + "\nProduct Name:" + productName + "\nProduct Price:" + price);
        }
    }


}

