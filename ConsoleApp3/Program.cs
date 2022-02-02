using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main1(string[] args)
        {
            string str;
            int alphabet, digit, specialchar, i, l;
            alphabet = digit = specialchar = i = 0;

            Console.Write("Enter the string:");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is: {0}\n", alphabet);
            Console.Write("Number of Digits in the string is: {0}\n", digit);
            Console.Write("Number of Special characters in the string is: {0}\n\n", specialchar);

            Console.ReadLine();
        }
    }
}
