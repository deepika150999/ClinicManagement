using Microsoft.AspNetCore.Mvc;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public  string LastName { get; set; }   
        public string Gender { get; set; }

        public static List<Employee> GetEmployeeData()
        {
            List<Employee> emp = new()
        {
            new Employee(){EmpId=101,FirstName="Arun",LastName="Kumaresan",Gender="male" },
            new Employee(){EmpId=102,FirstName="Dharani",LastName="ArunKumaresan",Gender="Female"},
            new Employee(){EmpId=103,FirstName="Satheesh",LastName="Kumaresan",Gender="Male"},
        new Employee(){EmpId=104,FirstName="Preethi",LastName="SatheeshKumaresan",Gender="Female"}
            };
            return emp;
        }
        public static Employee AddEmployeeData()
        {
            Employee emp1 = new();
            return emp1;

        }
        public static Employee Getsinglempdata()
        {
            Employee empl = new Employee()
            {
                EmpId = 105,
                FirstName = "Deepika",
                LastName = "Kumaresan",
                Gender = "Female"
            };
            return empl;
        }
    }
    

}
    

