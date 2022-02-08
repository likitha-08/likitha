using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Division
    {
        public static void Main3(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the first number:");
            do
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 != 0)
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Quotient is {0}", num1 / num2);
                        Console.WriteLine("Remainder is {0}", num1 % num2);
                        Console.WriteLine();
                    }
                }
            }
            while (num1 != 0);
        }

    }
}
