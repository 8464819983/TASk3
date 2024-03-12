using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASk3
{
    internal class Employee
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }


        public List<Employee> GetEmployeeDetails()
        {
            
            List<Employee> employees = new List<Employee>()
            {
            new Employee { ID = 1, Name = "bhargava", Position = "Manager" },
            new Employee { ID = 2, Name = "Jane Smith", Position = "Developer" }
            };

            return employees;
        }

        public void DisplayEmployeeDetails()
        {
            List<Employee> employees = GetEmployeeDetails();

            Console.WriteLine("Employee Details:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, ID: {employee.ID}, Position: {employee.Position}");
            }
        }


    }
}

