using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Defaultcs
    {
        public static void Main10()
        {
            IList<int> intlist = new List<int>() { 7, 9, 21, 37 };
            IList<string> strlist = new List<string>() { null, "two", "Three", "Four" };
            IList<string> emptylist = new List<string>();

            var sample = emptylist.DefaultIfEmpty("None");
            sample = sample.DefaultIfEmpty("None 1");
            Console.WriteLine(sample.Count());
            //var collection3 = strlist.Concat(emptylist);

            Console.WriteLine(intlist.First());
            Console.WriteLine(intlist.First(i => i % 2 == 0));
            Console.WriteLine(strlist.First());
            Console.WriteLine(emptylist.FirstOrDefault());

        }
    }
}
