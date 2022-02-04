using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public struct Person
    {
        public string Name;
        public int studentclass;
        
    }
    class ProblemStatement1
    {
        public static void Main2()
        {
            Person person;
            person.Name = "Rahul";
            person.studentclass = 4;

            Console.WriteLine("Data is stored in person Name:" + person.Name);
            Console.WriteLine("Data is stored in person Age:" + person.studentclass);
            
        }
       
    }
}
