using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2.Mock12
{
    class DomainComparer : IComparer<Contact>
    {
        public int Compare(Contact x, Contact y)
        {
            string s = "";
            int d = 0;
            string[] a;
          a = x.Email.Split('@');
            d = a[1].LastIndexOf('.');
            s = a[1].Substring(0, d);
            string s1 = "";
            a = y.Email.Split('@');
            d = a[1].LastIndexOf('.');
            s1 = a[1].Substring(0, d);
            if (s.CompareTo(s1) > 0)
            {
                return 1;
            }
            else if(s.CompareTo(s1)<0)
            {
                return -1;
            }
            else
                return 0;
        }
    }
}
