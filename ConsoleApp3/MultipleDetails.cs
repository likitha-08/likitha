using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Students
    {
        int StudentsID;
        string StudentsName;
        string StudentsGender;

        public void GetStudentsInformation()
        {
            Console.WriteLine("Please enter student Id");
            StudentsID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student Name");
            StudentsName = Console.ReadLine();
            Console.WriteLine("Please enter student Gender");
            StudentsGender = Console.ReadLine();
        }

        public void ShowStudentsData()
        {
            Console.WriteLine("Student Data :-");
            Console.WriteLine("Student Id : {0}", StudentsID);
            Console.WriteLine("Student Name : {0}", StudentsName);
            Console.WriteLine("Student Gender : {0}", StudentsGender);

        }
    }
    class MultipleDetails
    {
        static void Main5(string[] args)
        {
            Students[] student = new Students[2];

            for (int i = 0; i < student.Length; i++)
            {
                Students student1 = new Students();
                student1.GetStudentsInformation();
                student[i] = student1;
            }
            for (int i = 0; i < student.Length; i++)
            {
                student[i].ShowStudentsData();
            }
        }
    }
}
