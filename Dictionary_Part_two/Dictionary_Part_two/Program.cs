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

            Customer customer119 = dictionaryCustomers[119];

            //foreach(KeyValuePair<int,Customer> customerKeyValuePair in dictionaryCustomers)
            foreach(int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
                //Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                //Customer cust = customerKeyValuePair.Value;
               // Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
                //Console.WriteLine("-------------------------------------------------------");
            }
            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2} ", customer119.Id, customer119.Name, customer119.Salary);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}