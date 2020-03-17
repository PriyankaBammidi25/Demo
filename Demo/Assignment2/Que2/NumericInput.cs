using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Assignment2
{
    class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if(char.IsDigit(c))
            {
                s = s + c;
            }
        }
        static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            input.Add('1');
            Console.WriteLine(input.GetValue());
            Console.Read();

        }
    }

}
