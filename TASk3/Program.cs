
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Employee employee = new Employee();

            Console.WriteLine("Enter 1 for employe details, 2 for customer details:");
            string input = Console.ReadLine();

            if (input == "1")
            {
                customer.DisplayCustomerDetails();
            }
            else if (input == "2")
            {
                employee.DisplayEmployeeDetails();
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.ReadLine();
        }
    }
}
