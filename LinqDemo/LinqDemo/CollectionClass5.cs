using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class CollectionClass5
    {
        static void Main9()
        {
            IList<Student> sampleList = new List<Student>() {
                new Student { StudentId = 1, Age = 18, StudentName = "John" },
                new Student { StudentId = 2, Age = 21, StudentName = "Bill" },
                new Student { StudentId = 3, Age = 21, StudentName = "Ram" },
                new Student { StudentId = 4, Age = 18, StudentName = "Ravi" },
                new Student { StudentId = 5, Age = 21, StudentName = "Rob" },
                new Student { StudentId = 6, Age = 18, StudentName = "Kumar" }
            };

            bool allStudents = sampleList.All(s => s.Age > 12 && s.Age < 20);
            bool anyStudents = sampleList.Any(s => s.Age > 12 && s.Age < 20);
            Console.WriteLine(allStudents);
        }
    }
}
