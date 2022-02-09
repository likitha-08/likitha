using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class ArraySortExample
    {
        static void Main8(string[] args)
        {
            Console.WriteLine("Example of List");
            List<int> list = new List<int>();
            Console.WriteLine("Please enter name of languages");
            for (int i = 1; i< 5; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
             Console.WriteLine("Before Sorting of List");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //clear all data in the list
            //list.Clear();
              list.Sort();
            Console.WriteLine("After Sorting of List");
            foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                //this will help us to find some value or search value in list
                   bool flag = list.Contains(9);
                    if (flag)
                    {
                            Console.WriteLine("We are able to find 9 in the list");
                    }
                    else
            {
                Console.WriteLine(" 9 was not there in the list");
            }
            list.Remove(1);
            list.RemoveAt(1);
            Console.WriteLine("After removal of items from List");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
