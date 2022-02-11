using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class AnanonymousMethod
    {
        public delegate string GreetDelegate(string name);
        static void Main7(string[] args)
        {
            String Message = "HEY !";
            //GreetDelegate gd = new GreetDelegate(AnonymousMethods.Greet);
            GreetDelegate gd = delegate (string name)
            {
                return "Hello " + name + Message;
            };
            Console.WriteLine(gd.Invoke("Rahul Sharma"));
        }
    }
}
