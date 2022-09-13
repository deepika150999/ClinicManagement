using System;
public class EmployeeDetails
{
    public int emp_id;
    public int salary;
    public string name;
    public string address;
    public string department;
    public string email;
      public int getEmp_id()
    {
        return this.emp_id;
    }
    public void setEmp_id(int emp_id)
    {
        this.emp_id = emp_id;
    }
    public int getSalary()
    {
        return this.salary;
    }
    public void setSalary(int salary)
    {
        this.salary = salary;
    }
    public string getName()
    {
        return this.name;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public string getAddress()
    {
        return this.address;
    }
    public void setAddress(string address)
    {
        this.address = address;
    }
    public string getDepartment()
    {
        return this.department;
    }
    public void setDepartment(string department)
    {
        this.department = department;
    }
    public string getEmail()
    {
        return this.email;
    }
    public void setEmail(string email)
    {
        this.email = email;
    }
      public string toString()
    {
        return "Employee [emp_id = " + this.emp_id.ToString() + ", salary = " + this.salary.ToString() + ", name = " + this.name + ", address = " + this.address + ", department = " + this.department + ", email = " + this.email + "]";
    }
}
public class Employee
{
    
    public static void Main(string[] args)
    {
        var emp = new EmployeeDetails();
        Console.WriteLine("enter ur name");
string name = Console.ReadLine();
Console.WriteLine("enter ur age");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter Address");
string address = Console.ReadLine();
Console.WriteLine("enter empId");
int empid = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter ur salary");
int salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Join(", ",emp));
            var sal = emp.getSalary();
        var increment = 0;
              if ((sal >= 1000) && (sal <= 1500))
        {
            increment += (int)((sal * 2) / 100);
            sal = sal + increment;
            emp.setSalary(sal);
            Console.WriteLine("\n Salary is incremented \n");
            Console.WriteLine(string.Join(", ",emp));
        }
        else if ((sal >= 1500) && (sal <= 20000))

        {
            // incrementing salary 5%
            increment += (int)((sal * 5) / 100);
            sal = sal + increment;
            emp.setSalary(sal);
            Console.WriteLine("\n Salary is incremented \n");
            Console.WriteLine(string.Join(", ",emp));
        }
        else 
        {
            Console.WriteLine("\n Salary is not incremented \n");
            Console.WriteLine(string.Join(", ",emp));
        }
    }
}

