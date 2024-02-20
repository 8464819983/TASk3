using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASk3
{
    internal class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public List<Customer> GetCustomerDetails()
        {
            
            return new List<Customer>
            {
            new Customer { ID = 101, Name = "bhargava.", Address = "d.no 123" },
            new Customer { ID = 102, Name = "krishna", Address = "d.no 33" }
           
            };
            
        }

        public List<Customer> DisplayCustomerDetails()
        {
            List<Customer> customers = GetCustomerDetails();

            Console.WriteLine("Customer Details:");
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.Name}, ID: {customer.ID}, Address: {customer.Address}");
            }
            return customers;
        }
    }

   
}
