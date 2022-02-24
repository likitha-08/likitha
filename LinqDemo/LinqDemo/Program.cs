using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main1(string[] args)
        {
            string[] names = { "Bill", "James", "Mohan", "Ravi" };

            var linqquery = from name in names where name.Contains('i') select name;
            //var linqquery = from name in names select name;

            foreach (var item in linqquery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
