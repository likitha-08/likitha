using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CodeFirstContext context = new CodeFirstContext())
            {
                Department dept = new Department()
                {
                    Dep = "PHYSICS",

                    Students = new List<Student>
                    {
                        new Student(){Name="rahul"},
                        new Student(){Name="jhon"}
                    }
                };
                context.Departments.Add(dept);
                context.SaveChanges();
                Console.WriteLine("Data entered succesfully");
                Console.ReadKey();
            }
        }
    }
}