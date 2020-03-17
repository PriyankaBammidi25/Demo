using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2
{
  class TextInput
    {
        public string s = String.Empty;
         public virtual void Add(char c)
         {
            s += c;
         }
        
        public string GetValue()
        {
            return s;
        }
    }
}
