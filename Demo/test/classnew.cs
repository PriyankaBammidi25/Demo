using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.test
{
    class Student
    {
        string Name;
        int No;

        public Student(string name, int no)
        {
            Name = name;
            No = no;
        }
        public void display()
        {
            Console.WriteLine("Name" + Name);
            Console.WriteLine("No" + No);
        }

        static void Main(string[] args)
        {
            Student S = new Student("JOHN", 2);
            S.display();
            Console.Read();
        }
    }
}
