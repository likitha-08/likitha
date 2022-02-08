using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        Program()
        {

        }
        ~Program()
        {

        }
        static void Main1(string[] args)
        {
            Console.WriteLine("the generation are " + GC.GetTotalMemory(false));
            /*
            Program p = new Program();
            Console.WriteLine("the generation are " + GC.MaxGeneration);
            Console.WriteLine("the generation are " + GC.GetGeneration(p));
            Console.WriteLine("the generation are " + GC.GetTotalMemory(true));
            */

            //GC.Collect();
            //Console.WriteLine("GC in generation 0 {0}", GC.CollectionCount(0));
        }   
    }
}
