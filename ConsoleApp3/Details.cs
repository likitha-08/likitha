using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        int StudentID;
        string StudentName;
        string StudentGender;

        public void GetStudentInformation()
        {
            Console.WriteLine("Please enter student Id");
            StudentID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            StudentName = Console.ReadLine();
            Console.WriteLine("Please enter student Gender");
            StudentGender = Console.ReadLine();
        }

        public void ShowStudentData()
        {
            Console.WriteLine("Student Data :-");
            Console.WriteLine("Student Id : {0}", StudentID);
            Console.WriteLine("Student Name : {0}", StudentName);
            Console.WriteLine("Student Gender : {0}", StudentGender);

        }
    }
    class Details
    {
        static void Main3(string[] args)
        {

            Student student = new Student();
            student.GetStudentInformation();
            student.ShowStudentData();
        }
    }
}
