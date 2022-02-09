using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class StackExample
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            int total = 3;

            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                stack.Push(new People()
                {
                    Name = name,
                    Age = age
                });
            }

            for (int i = 0; i < total; i++)
            {
                People p = (People)stack.Pop();
                Console.WriteLine(p.ToString());
            }
        }
    }
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
}
