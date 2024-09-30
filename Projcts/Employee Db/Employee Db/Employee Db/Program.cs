using System;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;

namespace EmployeeManagementSystem
{
    class Program
    {
        static string connectionString = @"Data Source=DESKTOP-936JTB0;Initial Catalog=EmployeeDb;Integrated Security=True;Trust Server Certificate=True";
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

        //  Employee List to store employees
        static List<Employee> employees = new List<Employee>();

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

        // Metgod To add a Employee

        static void AddEmployee()
        {
            string insertQuery = "INSERT INTO STUDENTNEW (id, fName, lName, Email, Address, State) VALUES ('" + id + "', '" + fname + "', '" + lname + "', '" + email + "', '" + Address + "', '" + State + "')";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
            {
                try
                {
                    con.Open();
                    Console.WriteLine("Connection opened successfully.");
                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Student added successfully.");
                    }
                    else
                    {

                        Console.WriteLine("Student may not have been added.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding the student:");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                    Console.WriteLine("Connection closed.");
                }
               

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

            if (employee != null)
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
            if (employees.Count > 0)
            {
                Console.WriteLine("List of Employees is: ");
                foreach (var emp in employees)
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