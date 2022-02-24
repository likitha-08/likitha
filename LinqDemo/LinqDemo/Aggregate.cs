using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Aggregate
    {
        public static void Main8()
        {
            IList<string> strList = new List<string>() { "one", "two", "three", "four" };
            var commasepartedstring = strList.Aggregate((s1, s2) => s1 + " | " + s2);
            Console.WriteLine(commasepartedstring);
        }
    }
}
