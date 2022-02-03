using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Persons
    {
        public string Name { get; set; }

        public Persons(string name)
        {
            Name = name;
        }

        public override string ToString()
        { 
            return "My name is " + Name;
        }
        ~Persons()
        {
            Name = string.Empty;
        }
    }
    public class ProblemStatement
    {
        public static void Main3(string[] args)
        {
            int total = 3;
            Persons[] persons = new Persons[total];
            Console.WriteLine("Enter the names:");

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Persons(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
        }
    }
}
