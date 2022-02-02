using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Employee
    {
        int EmployeeID;
        string EmployeeName;
        double EmployeeSalary;
        string EmployeeGender;
        long  EmployeePh;

        public void GetEmployeeInformation()
        {
            Console.WriteLine("Please enter employee Id");
            EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter employee Name");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Please enter employee Salary");
            EmployeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter employee Gender");
            EmployeeGender = Console.ReadLine();
            Console.WriteLine("Please enter employee Ph number");
            EmployeePh = Convert.ToInt64(Console.ReadLine());
        }

        public void ShowEmployeeData()
        {
            Console.WriteLine("Employee Data :-");
            Console.WriteLine("Employee Id : {0}", EmployeeID);
            Console.WriteLine("Employee Name : {0}", EmployeeName);
            Console.WriteLine("Employee Salary : {0}", EmployeeSalary);
            Console.WriteLine("Employee Gender : {0}", EmployeeGender);
            Console.WriteLine("Employee Ph number : {0}", EmployeePh);
        }
    }

    class DataOfEemployee
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetEmployeeInformation();
            employee.ShowEmployeeData();
        }
    }
}
