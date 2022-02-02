using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class NormParmeters
    {
        static int Sum(params int[] param1)
        {
            int val = 0;
            foreach (var item in param1)
            {
                val = val + item;
            }
            return val;
        }
        static void Main9(string[] args)
        {

            Console.WriteLine(Sum());
        }
    }
}
