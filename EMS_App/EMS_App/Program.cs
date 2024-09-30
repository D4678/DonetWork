using System;
using System.Reflection;
using Microsoft.Data.SqlClient;

namespace EmployeeManagementSystem
{
    class Program
    {
        static string connectionString = @"Data Source=DESKTOP-936JTB0;Initial Catalog=EmsDb;Integrated Security=True;Trust Server Certificate=True";

        static void Main()
        {
            while(true)
            {
                Console.WriteLine("Welcome To Employee Management System");
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
                        InsertEmployeeDetails();
                            break;

                    case "2":
                        UpdateEmployeeDetails();
                        break;

                    case "3":
                        DeleteEmployeeDetails();
                        break;

                    case "4":
                        DisplayAllEmployee();
                        break;

                    case "5":
                       Console.WriteLine("Bye");
                        return;

                    default:
                        Console.WriteLine("Invalid Input !! Try Again");
                        break;
                }
                Console.WriteLine("===============================================================================");
            }
        }
       
        // Method to insert employee data into the employees table
        static void InsertEmployee(int employeeId, string firstName, string lastName, string email, int mobile, string address)
        {
            // This line should be match in your database table name:
            string query = "INSERT INTO Employees (Empid, EmpFirstName, EmpLastName, EmpEmail, EmpMobile, EmpAddress) VALUES (@Empid, @EmpFirstName, @EmpLastName, @EmpEmail, @EmpMobile, @EmpAddress)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Empid", employeeId);  // employeeId should be match in InsertEmployee Method (Line 33 :)
                command.Parameters.AddWithValue("@EmpFirstName", firstName);
                command.Parameters.AddWithValue("@EmpLastName", lastName);
                command.Parameters.AddWithValue("@EmpEmail", email);
                command.Parameters.AddWithValue("@EmpMobile", mobile);
                command.Parameters.AddWithValue("@EmpAddress", address);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    
                    if(result > 0)
                    {
                        Console.WriteLine("Employee Added SuccessFully");
                    }
                    else
                    {
                        Console.WriteLine("Insertion Operation Failed");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("An Error Occured : " + e.Message);
                }
            }
        }

        // Method to collect data at insertion
        static void InsertEmployeeDetails()
        {
            // Collect employee data for insertion
            Console.Write("Enter Employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());

            if (employeeId < 1)
            {
                Console.WriteLine("Error: Employee Id Must be Greater than 0");
                return;
            }

            Console.Write("Enter First Name: ");
            string? firstName = Console.ReadLine();

            if (string.IsNullOrEmpty(firstName))
            {
                Console.WriteLine("First name Cannot be empty");
                return;
            }


            Console.Write("Enter Last Name: ");
            string? lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string? email = Console.ReadLine();

            Console.Write("Enter Mobile Number: ");
            int mobileNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Address: ");
            string? address = Console.ReadLine();

            InsertEmployee(employeeId, firstName, lastName, email, mobileNo, address);

        }

        // Method to update employee data in the Employees table
        static void UpdateEmployee(int employeeId, string email, int mobileNo, string address)
        {
            string query = "UPDATE Employees SET EmpEmail = @EmpEmail, EmpMobile = @EmpMobile, EmpAddress = @EmpAddress WHERE Empid = @Empid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand (query, connection);
                command.Parameters.AddWithValue("@Empid", employeeId);
                command.Parameters.AddWithValue("@EmpEmail", email);
                command.Parameters.AddWithValue("@EmpMobile", mobileNo);
                command.Parameters.AddWithValue("@EmpAddress", address);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Employee Details Updated SuccessFully");
                    }
                    else
                    {
                        Console.WriteLine("Updation Operation Failed");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An Error Occured : " + e.Message);
                }
            }
            
        }

        // Method To Update employee
        static void UpdateEmployeeDetails()
        {
            Console.Write("Enter Employee ID to update: ");
            int employeeId = int.Parse(Console.ReadLine());

            Console.Write("Enter new Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter new Mobile Number: ");
            int mobileNo = int.Parse(Console.ReadLine());

            Console.Write("Enter new Address: ");
            string address = Console.ReadLine();

            // Call the update method to update the employee data in the database
            UpdateEmployee(employeeId, email, mobileNo, address);
        }

        // Method To Delete An employee
        static void DeleteEmployee(int employeeId)
        {
            string query = "DELETE FROM Employees WHERE Empid = @Empid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Empid", employeeId);


                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("Employee Deleted SuccessFully");
                    }
                    else
                    {
                        Console.WriteLine("Deletion Operation Failed");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An Error Occured : " + e.Message);
                }
            }
        }

        // Method to collect employee ID for deletion
        static void DeleteEmployeeDetails()
        {
            Console.Write("Enter the Employee ID to delete: ");
            int employeeIdToDelete = int.Parse(Console.ReadLine());
            DeleteEmployee(employeeIdToDelete);
        }

        // Method to display Employee Data 
        static void DisplayAllEmployee()
        {
            string query = "SELECT *FROM Employees";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Check if there are rows to display
                    if (reader.HasRows)
                    {
                        Console.WriteLine("\nEmployee Details:");
                        Console.WriteLine("-------------------------------------------------");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["Empid"]}");
                            Console.WriteLine($"Name: {reader["EmpFirstName"]} {reader["EmpLastName"]}");
                            Console.WriteLine($"Email: {reader["EmpEmail"]}");
                            Console.WriteLine($"Mobile No: {reader["EmpMobile"]}");
                            Console.WriteLine($"Address: {reader["EmpAddress"]}");
                            Console.WriteLine("-------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No employees found.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    

    }
}