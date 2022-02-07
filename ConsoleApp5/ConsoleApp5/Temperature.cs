using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) : base(message)
        {

        }
    }
    public class Temperature
    {
        int temperature = 36;
        public void ShowTemperature()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature :{0}", temperature);
            }
        }
        static void Main5(string[] args)
        {
            Temperature testTemprature = new Temperature();
            try
            {
                int a = 5;
                int b = a / 0;
                testTemprature.ShowTemperature();
            }
            catch (TempIsZeroException ex)
            {
                Console.WriteLine("Custom execption is {0}", ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
