using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class CelciusConversion
    {
        public static void Main4(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celcius:");
            int Celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("temperature in kelvin= {0}", Celsius + 273);
            Console.WriteLine("temperature in fahrenheit= {0}", Celsius * 18 / 10 + 32);
        }

    }
}
