using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main1(string[] args)
        {
           int i, n, sum = 0;
            Console.Write("sum of n natural numbers:\n");

            Console.Write("enter the no of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write(" \n Sum of Natural Number upto {0} terms : {1} \n\n\n", n, sum);

            while (i <= n)
            {
                sum += i;
                i++;
            }

            Console.WriteLine("Total sum: " + sum);
        }

    }
}
