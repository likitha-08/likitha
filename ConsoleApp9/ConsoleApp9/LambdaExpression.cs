using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class LambdaExpression
    {
        public delegate string GreetDelegate(string name);
        static void Main8(string[] args)
        {
            String Message = "HEY !";
            GreetDelegate gd = (name) =>
            {
                return "Hello " + name + Message;
            };
            Console.WriteLine(gd.Invoke("MICHLE JHON"));
        }
    }
}
