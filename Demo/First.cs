﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class First
    {
        static void Main(string[] args)
        {

            int n=3;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                for (int k = 1; k < i; k++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 0; j < (n - i); j++)
                    Console.Write("  ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                for (int k = 1; k < i; k++)
                    Console.Write("* ");
                Console.WriteLine();
            }
                Console.Read();
        }
    }
}
