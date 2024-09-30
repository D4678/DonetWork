using System;

namespace EmployeeManagementSystem
{
    class Program
    {
        // Employee class to hold the employee information 
        class Employee
        {
            public int EmployeeId { get; set; }
            public string ?EmployeeFirstName { get; set; }
            public string ?EmployeeLastName { get; set; }
            public string ?EmployeeEmail { get; set; }
            public int ?EmployeeMobileNo { get; set; }
            public string ?EmployeeAddress { get; set; }

        }

        //  Employee List to store employees
        static List<Employee> employees  =  new List<Employee>();

        static void Main()
        {
            while(true)
            {
                Console.WriteLine("Welcome to Employee Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Display All Employees");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        AddEmployee();
                        break;

                    case "2":
                        UpdateEmployee();
                        break;

                    case "3":
                        DeleteEmployee();
                        break;

                    case "4":
                        DisplayAllEmployee();
                        break;

                    case "5":
                        Console.WriteLine("Bye");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice ? Please try Again");
                        break;

                }
                Console.WriteLine();

            }
        }

        static void AddEmployee()
        {
            Employee employee = new Employee();

            Console.WriteLine("Enter Employee ID: ");
            employee.EmployeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee First Name: ");
            employee.EmployeeFirstName = Console.ReadLine();

            Console.WriteLine("Enter Employee Last Name: ");
            employee.EmployeeLastName = Console.ReadLine();

            Console.WriteLine("Enter The Email: ");
            employee.EmployeeEmail = Console.ReadLine();

            Console.WriteLine("Enter The Mobile Number: ");
            employee.EmployeeMobileNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Address");
            employee.EmployeeAddress = Console.ReadLine();

            employees.Add(employee);
            Console.WriteLine("Employee added successfully!");

        }

        // Method to update an employee's information

        static void UpdateEmployee()
        {
            Console.WriteLine("Enter the employee Id To be Update: ");
            int id = int.Parse(Console.ReadLine());

            Employee employee = employees.Find(emp => emp.EmployeeId == id);

            if (employee != null)
            {
                Console.Write("Enter new First Name: ");
                employee.EmployeeFirstName = Console.ReadLine();

                Console.Write("Enter new Last Name: ");
                employee.EmployeeLastName = Console.ReadLine();

                Console.WriteLine("Enter The Mobile Number: ");
                employee.EmployeeMobileNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter The Address");
                employee.EmployeeAddress = Console.ReadLine();

                Console.WriteLine("Employee details updated successfully!");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
            

        }

        
        // Method To delete An employee
        static void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee Id To be Delete");
            int id = int.Parse(Console.ReadLine());

            Employee employee = employees.Find(emp => emp.EmployeeId == id);

            if(employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Employee Not Found");
            }

        }
        

        // Method to display All employee
        static void DisplayAllEmployee()
        {
            if(employees.Count > 0)
            {
                Console.WriteLine("List of Employees is: ");
                foreach(var emp in employees)
                {
                    Console.WriteLine($"ID : {emp.EmployeeId}, EmployeeFirstName: {emp.EmployeeFirstName}, EmployeelastName: {emp.EmployeeLastName}, EmployeeEmail: {emp.EmployeeEmail}, EmplyeeMobile: {emp.EmployeeMobileNo}");
                }
            }
            else
            {
                Console.WriteLine("No Employee Found.");
            }
        }
    }
}