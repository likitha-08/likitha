using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class StaticSample
    {
        static StaticSample()
        {

        }
        public static string a = "Sample";
    }
    class StaticKeyword
    {
        static void Main6(string[] args)
        {
            StaticSample staticSample = new StaticSample();
            StaticSample.a = "happy";

            Console.WriteLine(StaticSample.a);

        }
    }
}
