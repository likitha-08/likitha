using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Problem1
    {
        public class sample<T>
        {
            private T data;

            public T value
            {
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }
        public class Employee
        {
            public int EmpolyeeID { get; set; }
            public string EmpolyeeName { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
        }
        static void Main3(string[] args)
        {
            Employee std = new Employee()
            {
                EmpolyeeID = 10431,
                EmpolyeeName = "RAHUL",
                Age = 24,
                Address = "Hyderabad "
            };
            Console.WriteLine("Employee Information");
            Console.WriteLine(std.EmpolyeeID);
            Console.WriteLine(std.EmpolyeeName);
            Console.WriteLine(std.Age);
            Console.WriteLine(std.Address);
        }
    }
}
