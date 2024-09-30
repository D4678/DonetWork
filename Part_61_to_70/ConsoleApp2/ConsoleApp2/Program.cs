using System;
using System.Collections.Generic;
using System.Data.SqlClient; // Include this to work with SQL
using System.Data;

namespace EmployeeManagementSystem
{
    class Program
    {
        // Database connection string (adjust server name, database, and credentials as needed)
        static string connectionString = @"Data Source=DESKTOP-936JTB0;Initial Catalog=EmployeeDb;Integrated Security=True";

        // Employee class to hold the employee information 
        class Employee
        {
            public int EmployeeId { get; set; }
            public string? EmployeeFirstName { get; set; }
            public string? EmployeeLastName { get; set; }
            public string? EmployeeEmail { get; set; }
            public int? EmployeeMobileNo { get; set; }
            public string? EmployeeAddress { get; set; }
        }

        static void Main()
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

                    //case "2":
                    //    UpdateEmployee();
                    //    break;

                    //case "3":
                    //    DeleteEmployee();
                    //    break;

                    //case "4":
                    //    DisplayAllEmployee();
                    //    break;

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

            // Insert employee data into database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employees (EmployeeId, FirstName, LastName, Email, MobileNo, Address) " +
                               "VALUES (@EmployeeId, @FirstName, @LastName, @Email, @MobileNo, @Address)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                command.Parameters.AddWithValue("@FirstName", employee.EmployeeFirstName);
                command.Parameters.AddWithValue("@LastName", employee.EmployeeLastName);
                command.Parameters.AddWithValue("@Email", employee.EmployeeEmail);
                command.Parameters.AddWithValue("@MobileNo", employee.EmployeeMobileNo);
                command.Parameters.AddWithValue("@Address", employee.EmployeeAddress);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            Console.WriteLine("Employee added successfully!");
        }

    }
}
