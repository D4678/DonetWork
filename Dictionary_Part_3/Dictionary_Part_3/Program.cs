
using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Mark",
                Salary = 50000
            };

            Customer customer2 = new Customer()
            {
                Id = 110,
                Name = "Bob",
                Salary = 6000
            };

            Customer customer3 = new Customer()
            {
                Id = 119,
                Name = "Marry",
                Salary = 70000
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.Id, customer1);
            dictionaryCustomers.Add(customer2.Id, customer2);
            dictionaryCustomers.Add(customer3.Id, customer3);

            Console.WriteLine("Total items = {0}", dictionaryCustomers.Count(kvp=>kvp.Value.Salary >40000));
            Customer ?cust;
            if(dictionaryCustomers.TryGetValue(101, out cust))
            {
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
            }
            else
            {
                Console.WriteLine("The Key is Not Found");
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public int Salary { get; set; }
    }
}