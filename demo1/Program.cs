using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Program
    {
        static void Main(string[] args)
        {
			int age;
			Console.Write("Enter age of a person:");
			age = Convert.ToInt32(Console.ReadLine());

			if (age >= 18)
			{
				Console.WriteLine("person is allowed for voting:" + age);
			}
			else
			{
				Console.WriteLine("User is not allowed for voting:" + age);
			}
		}
    }
}

