using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        public class sample<T>
        {
            private T data;

            public T value
            {
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }

        }
        static void Main1(string[] args)
        {
            sample<string> name = new sample<string>();
            name.value = "LIKITHA";

            sample<int> version = new sample<int>();
            version.value = 4;
            //display Name
            Console.WriteLine(name.value);
            //display version
            Console.WriteLine(version.value);
        }
    }
}
