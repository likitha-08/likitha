using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Problem3
    {
        static int Main()
        {
            string Name;
            string ageText;
            int age;
            int result = 0;

            Console.Write("Enter your first name: ");
            Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            ageText = Console.ReadLine();

            try
            {
                age = int.Parse(ageText);
                Console.WriteLine("Hi { Name }! You are { age * 12 } months old.");
            }
            finally
            {
                Console.WriteLine(" { Name }");
            }

            return result;
        }
    }
}
