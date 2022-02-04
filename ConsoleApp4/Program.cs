using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    struct Students
    {
        public int rollNumber;
        public string name;

        static Students()
        {
            Console.WriteLine("Object 1");
        }

        public Students(int r, string n)
        {
            rollNumber = r;
            name = n;
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            Students s = new Students(1, "xyz");
            Console.WriteLine(s.rollNumber);
            Console.WriteLine(s.name);
        }
    }
}
