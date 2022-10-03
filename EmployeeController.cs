 using Microsoft.AspNetCore.Mvc;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeData()
        {
        List<Employee> employees = Employee.GetEmployeeData();
            return View(employees);
        }
        public IActionResult AddEmployeeData() 
        {
            Employee employe =new Employee();
            return View(employe);
        }
        public IActionResult Getsinglempdata()
        {
            Employee empl = new Employee()
            {
                EmpId = 105,
                FirstName = "Deepika",
                LastName = "Kumaresan",
                Gender = "Female"
            };
            return View(empl);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
