using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class ListExample
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Example of List");
            List<string> list = new List<string>();
            Console.WriteLine("Please enter name of languages");
            for (int i = 1; i < 3; i++)
            {
                list.Add(Console.ReadLine());
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
