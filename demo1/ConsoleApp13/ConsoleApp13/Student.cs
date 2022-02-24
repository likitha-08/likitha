using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Departments { get; set; }
    }
}
