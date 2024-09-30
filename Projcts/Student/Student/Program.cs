using System;


namespace EmployeeManagementSystem
{
    class Program
    {
        // Employee class to hold employee information
        class Employee
        {
           
            public int EmployeeID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        // Employee List to store employees
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Employee Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display All Employees");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;               
                    case "2":
                        DisplayAllEmployees();
                        break;
                    case "3":
                        Console.WriteLine(" Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
                Console.WriteLine(); 
            }
        }

        // Method to add an employee
        static void AddEmployee()
        {
            Employee employee = new Employee();

            //Console.Write("Enter Employee ID: ");
            //employee.EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter First Name: ");
            employee.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            employee.LastName = Console.ReadLine();

            employees.Add(employee);
            Console.WriteLine("Employee added successfully!");
        }

   


        // Method to display all employees
        static void DisplayAllEmployees()
        {
            if (employees.Count > 0)
            {
                Console.WriteLine("List of Employees:");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID: {emp.EmployeeID}, Name: {emp.FirstName} {emp.LastName}");
                }
            }
            else
            {
                Console.WriteLine("No employees found.");
            }
        }
    }
}
