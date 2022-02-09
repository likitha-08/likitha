using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class ArrayListObject
    {
        public static void Main9(string[] args)
        {
            ArrayList list = new ArrayList();

            int total = 3;
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                list.Add(new ProblemArrayList()
                {
                    Name = name,
                    Age = age
                });
            }
            foreach (ProblemArrayList p in list)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }
        class ProblemArrayList
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
