using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class IndexerCreation
    {
        private string[] val = new string[3];

        public string this[int index]
        {
            get
            {
                return val[index];
            }
            set
            {
                val[index] = value;
            }
        }

    }
    class Indexers
    {
        public static void Main5()
        {
            IndexerCreation ic = new IndexerCreation();
            ic[0] = "CAT";
            ic[1] = "DOG";
            ic[2] = "RAT";
            Console.WriteLine("First Value= {0}", ic[0]);
            Console.WriteLine("Second Value = {0}", ic[01]);
            Console.WriteLine("Third Value = {0}", ic[2]);
        }
    }
}
