using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test2
{
    class Book
    {
        int BOOK_NO;
        string BOOKTITLE;
        float PRICE;
        int n;
        public void INPUT(int BOOK_N0,string BOOKTITLE,float PRICE)
        {
            this.BOOK_NO = BOOK_NO;
            this.BOOKTITLE = BOOKTITLE;
            this.PRICE = PRICE;

        }
        public void PURCHASE()
        {
            int n = int.Parse(Console.ReadLine());
            Total_Cost(n);
            Console.WriteLine("Total cost" + Total_Cost(n));
        }
            double Total_Cost(int n)
            {
            return n * PRICE;
            }
        

    }
}
