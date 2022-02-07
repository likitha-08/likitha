using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Problem2
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;
            try
            {
                throw new Exception("Some error have occured");
                Console.WriteLine("Value of a is {0}", a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Hi I am in finally block");
            }
        }
    }
}
