using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Employee
    {
        public int EmpID;
        public int Salary;
        public int DepID;
        public string EmpName;
    }
    public class Department
    {
        public int DepID;
        public string DepName;
    }

    class ProblemStatement1cs
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
        {
             new Employee {EmpID=401,   EmpName="jhon"     , Salary=4000,DepID=401},
             new Employee {EmpID=402,   EmpName="rahul"    , Salary=6000,DepID=402},
             new Employee {EmpID=403,   EmpName="Sam"      , Salary=7400,DepID=403},
             new Employee {EmpID=404,   EmpName="gotam "   , Salary=2000,DepID=404},
         };

            List<Department> departments = new List<Department>()
        {
             new Department {DepID=401,   DepName="HR        "   },
             new Department {DepID=402,   DepName="ACCOUNTS  "   },
             new Department {DepID=403,   DepName="SALES     "   },
        };
            var Result = employees.Join(departments,
                           emp => emp.DepID,
                           dept => dept.DepID,
                           (emp, dept) => new
                           {
                               ID = emp.EmpID,
                               Name = emp.EmpName,
                               Salary = emp.Salary,
                               DeptName = dept.DepName

                           }).ToList();

            foreach (var e in Result)
            {
                Console.WriteLine("ID: " + e.ID + ", Name: " + e.Name + ", Salary: " + e.Salary + ", Department: " + e.DeptName);
            }
        }
    }
}
