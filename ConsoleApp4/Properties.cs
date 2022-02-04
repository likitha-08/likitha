using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Student
    {
        private int rn = 402;
        private string name;

        public int RollNumber
        {
            get
            {
                return rn;
            }
            set
            {
                rn = value;
            }
        }
        public int Name { get; set; }
    }
    class Properties
    {
        public static void Main3()
        {
            Student objStudent = new Student();
            Console.WriteLine(objStudent.RollNumber);
        }
    }
}
