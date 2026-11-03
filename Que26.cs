using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Questions
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Employee(int employeeId, string name, string email)
        {
            EmployeeId = employeeId;
            Name = name;
            Email = email;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    public class Manager : Employee {
        public string Department { get; set; }
        public int TeamSize { get; set; }
        public Manager(int employeeId, string name, string email, string department, int teamSize) : base(employeeId, name, email)
        {
            if (teamSize <= 0)
            {
                throw new Exception("Team size must be greater than zero");
            }
            Department = department;
            TeamSize = teamSize;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Team Size: {TeamSize}");
        }

    }
    public class Que26
    {
        public static void Run()
        {
            Employee[] employees =
            {
                new Employee(101, "Yuvraj", "email@email.com"),
                new Employee(103, "Rahul", "yes@email.com"),
                new Employee(501, "No", "no@email.com"),
                new Manager(104, "Rohit", "rohit@email.com", "IT", 10)
            };
        }
    }
}
