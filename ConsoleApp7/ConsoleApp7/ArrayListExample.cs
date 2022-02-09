using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class ArrayListObjects
    {
        public static void Main6(string[] args)
        {
            ArrayList list = new ArrayList();

            int total = 3;
            Console.WriteLine("enter the name and age");
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                list.Add(new ArrayListExample()
                {
                    Name = name,
                    Age = age
                });
            }

            foreach (ArrayListExample p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }
        class ArrayListExample
        { 
            public string Name { get; set; }
            public int Age { get; set; }


            public override string ToString()
            {
                return Name + " - " + Age;
            }
        }
    }
}
