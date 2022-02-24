using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    { 
        IList< Employee > employees = new List< Employee >()
        {
            new Employee()
                { EmployeeId = 1, EmployeeName = "Rahul", EmployeeAge =31, EmployeeDOB = 04-05-1996 },
            new Employee()
                { EmployeeId = 1, EmployeeName = "Jhon", EmployeeAge = 32, EmployeeDOB = 04-05-1996 },
            new Employee()
                { EmployeeId = 1, EmployeeName = "Riya", EmployeeAge = 30, EmployeeDOB = 04-05-1996 },
        };

        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}
