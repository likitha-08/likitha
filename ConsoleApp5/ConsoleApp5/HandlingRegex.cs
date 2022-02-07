using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    internal class HandlingRegex
    {
        static void Main4(string[] args)
        {
            //this will return any pattern line ab,aab,aaab;
            //Regex re = new Regex("a*b");
            //this will return pattern like b,ab
            Regex re = new Regex("a?b");
            Match match = re.Match("aaaaabcd");
            if (match.Success)
            {
                Console.WriteLine("Mached the value " + match.Value);
            }
        }
    }
}
